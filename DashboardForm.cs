using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class DashboardForm : Form
    {
        private DatabaseHelper dbHelper;
        private Timer refreshTimer;

        public DashboardForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();

            // إعداد مؤقت للتحديث التلقائي كل 30 ثانية
            refreshTimer = new Timer();
            refreshTimer.Interval = 30000; // 30 ثانية
            refreshTimer.Tick += (s, ev) => LoadDashboardData();
            refreshTimer.Start();
        }

        private void LoadDashboardData()
        {
            try
            {
               
                if (!dbHelper.TestConnection())
                {
                    MessageBox.Show("لا يمكن الاتصال بقاعدة البيانات", "خطأ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadStatistics();
                LoadBorrowedBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات لوحة التحكم: " + ex.Message, "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatistics()
        {
            // إجمالي الكتب
            string totalBooksQuery = "SELECT COUNT(*) FROM books";
            int totalBooks = Convert.ToInt32(dbHelper.ExecuteScalar(totalBooksQuery));
            lblTotalBooksValue.Text = totalBooks.ToString();

            // إجمالي الكميات المتاحة
            string availableBooksQuery = "SELECT COALESCE(SUM(quantity), 0) FROM books";
            int availableBooks = Convert.ToInt32(dbHelper.ExecuteScalar(availableBooksQuery));
            lblAvailableBooksValue.Text = availableBooks.ToString();

            // الكتب المستعارة (إجمالي الكتب - المتاحة)
            int borrowedBooks = totalBooks - availableBooks;
            lblBorrowedBooksValue.Text = borrowedBooks.ToString();

            // إجمالي الأعضاء
            string totalMembersQuery = "SELECT COUNT(*) FROM members";
            int totalMembers = Convert.ToInt32(dbHelper.ExecuteScalar(totalMembersQuery));
            lblTotalMembersValue.Text = totalMembers.ToString();

            // الاستعارات النشطة
            string activeBorrowingsQuery = "SELECT COUNT(*) FROM borrowings WHERE status = 'مستعار'";
            int activeBorrowings = Convert.ToInt32(dbHelper.ExecuteScalar(activeBorrowingsQuery));
            lblActiveBorrowingsValue.Text = activeBorrowings.ToString();
        }

        private void LoadBorrowedBooks()
        {
            string query = @"SELECT 
                           b.borrow_id as 'رقم الاستعارة',
                           m.name as 'اسم العضو',
                           bk.title as 'عنوان الكتاب',
                           b.borrow_date as 'تاريخ الاستعارة',
                           b.return_date as 'موعد الإرجاع',
                           DATEDIFF(b.return_date, CURDATE()) as 'الأيام المتبقية'
                         FROM borrowings b
                         JOIN members m ON b.member_id = m.member_id
                         JOIN books bk ON b.book_id = bk.book_id
                         WHERE b.status = 'مستعار'
                         ORDER BY b.return_date ASC";

            DataTable borrowedBooksTable = dbHelper.ExecuteQuery(query);
            dataGridViewBorrowedBooks.DataSource = borrowedBooksTable;


            foreach (DataGridViewRow row in dataGridViewBorrowedBooks.Rows)
            {
                if (row.Cells["الأيام المتبقية"].Value != null)
                {
                    int daysLeft = Convert.ToInt32(row.Cells["الأيام المتبقية"].Value);
                    if (daysLeft < 0)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral; // متأخر
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkRed;
                    }
                    else if (daysLeft <= 2)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow; 
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen; 
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen;
                    }
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            refreshTimer?.Stop();
            refreshTimer?.Dispose();
        }

        private void lblTotalBooksValue_Click(object sender, EventArgs e)
        {

        }
    }
}