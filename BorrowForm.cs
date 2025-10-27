

using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BorrowForm : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable borrowingsTable;

        public BorrowForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void BorrowForm_Load(object sender, EventArgs e)

        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            LoadBorrowings();
            LoadMembersCombo();
            LoadBooksCombo();
            dtpBorrowDate.Value = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now;
        }

        private void LoadMembersCombo()
        {
            try
            {
                string query = "SELECT member_id, name FROM members ORDER BY name";
                DataTable members = dbHelper.ExecuteQuery(query);

                cmbMembers.DisplayMember = "name";
                cmbMembers.ValueMember = "member_id";
                cmbMembers.DataSource = members;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل قائمة الأعضاء: " + ex.Message, "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBooksCombo()
        {
            try
            {
                string query = "SELECT book_id, title FROM books WHERE quantity > 0 ORDER BY title";
                DataTable books = dbHelper.ExecuteQuery(query);

                cmbBooks.DisplayMember = "title";
                cmbBooks.ValueMember = "book_id";
                cmbBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل قائمة الكتب: " + ex.Message, "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBorrowings()
        {
            try
            {
                string query = @"SELECT b.borrow_id, m.name as member_name, bk.title as book_title, 
                                b.borrow_date, b.return_date, b.status
                                FROM borrowings b
                                JOIN members m ON b.member_id = m.member_id
                                JOIN books bk ON b.book_id = bk.book_id
                                ORDER BY b.borrow_date DESC";

                borrowingsTable = dbHelper.ExecuteQuery(query);
                dataGridViewBorrowings.DataSource = borrowingsTable;

                
                if (dataGridViewBorrowings.Columns.Count > 0)
                {
                    dataGridViewBorrowings.Columns["borrow_id"].HeaderText = "رقم الاستعارة";
                    dataGridViewBorrowings.Columns["member_name"].HeaderText = "اسم العضو";
                    dataGridViewBorrowings.Columns["book_title"].HeaderText = "عنوان الكتاب";
                    dataGridViewBorrowings.Columns["borrow_date"].HeaderText = "تاريخ الاستعارة";
                    dataGridViewBorrowings.Columns["return_date"].HeaderText = "تاريخ الإرجاع";
                    dataGridViewBorrowings.Columns["status"].HeaderText = "الحالة";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات الاستعارات: " + ex.Message, "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewBorrowings_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBorrowings.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBorrowings.SelectedRows[0];
                string memberName = selectedRow.Cells["member_name"].Value.ToString();
                string bookTitle = selectedRow.Cells["book_title"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();

                lblBorrowInfo.Text = $"{memberName} - {bookTitle}\nالحالة: {status}";
            }
        }

        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            if (cmbMembers.SelectedItem == null || cmbBooks.SelectedItem == null)
            {
                MessageBox.Show("يرجى اختيار عضو وكتاب", "تنبيه",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int memberId = Convert.ToInt32(cmbMembers.SelectedValue);
                int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
                DateTime borrowDate = dtpBorrowDate.Value;
                DateTime returnDate = borrowDate.AddDays(14); 

                string checkQuantityQuery = $"SELECT quantity FROM books WHERE book_id = {bookId}";
                int currentQuantity = Convert.ToInt32(dbHelper.ExecuteScalar(checkQuantityQuery));

                if (currentQuantity <= 0)
                {
                    MessageBox.Show("هذا الكتاب غير متوفر حالياً", "تنبيه",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertQuery = $@"INSERT INTO borrowings (member_id, book_id, borrow_date, return_date, status) 
                                      VALUES ({memberId}, {bookId}, '{borrowDate:yyyy-MM-dd}', '{returnDate:yyyy-MM-dd}', 'مستعار')";

                string updateBookQuery = $"UPDATE books SET quantity = quantity - 1 WHERE book_id = {bookId}";

                int rowsAffected = dbHelper.ExecuteNonQuery(insertQuery);
                if (rowsAffected > 0)
                {
                    dbHelper.ExecuteNonQuery(updateBookQuery);
                    MessageBox.Show("تم تسجيل الاستعارة بنجاح", "نجاح",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBorrowings();
                    LoadBooksCombo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تسجيل الاستعارة: " + ex.Message, "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (dataGridViewBorrowings.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار استعارة لتسجيل الإرجاع", "تنبيه",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewBorrowings.SelectedRows[0];
            int borrowId = Convert.ToInt32(selectedRow.Cells["borrow_id"].Value);
            int bookId = GetBookIdFromBorrowing(borrowId);
            string status = selectedRow.Cells["status"].Value.ToString();

            if (status == "تم الإرجاع")
            {
                MessageBox.Show("هذا الكتاب تم إرجاعه مسبقاً", "تنبيه",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DateTime returnDate = dtpReturnDate.Value;

                string updateBorrowQuery = $@"UPDATE borrowings 
                                            SET return_date = '{returnDate:yyyy-MM-dd}', 
                                                status = 'تم الإرجاع' 
                                            WHERE borrow_id = {borrowId}";

                string updateBookQuery = $"UPDATE books SET quantity = quantity + 1 WHERE book_id = {bookId}";

                int rowsAffected = dbHelper.ExecuteNonQuery(updateBorrowQuery);
                if (rowsAffected > 0)
                {
                    dbHelper.ExecuteNonQuery(updateBookQuery);

                    DateTime expectedReturn = Convert.ToDateTime(selectedRow.Cells["return_date"].Value);
                    if (returnDate > expectedReturn)
                    {
                        int daysLate = (returnDate - expectedReturn).Days;
                        decimal fine = daysLate * 5; 
                        MessageBox.Show($"تم تسجيل الإرجاع بنجاح\nتأخير {daysLate} يوم\nالغرامة: {fine} وحدة نقدية",
                                      "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("تم تسجيل الإرجاع بنجاح", "نجاح",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadBorrowings();
                    LoadBooksCombo();
                    lblBorrowInfo.Text = "---";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تسجيل الإرجاع: " + ex.Message, "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد من مسح جدول الاستعارات من العرض فقط؟",
                                                  "تأكيد",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ClearBorrowingsGrid();
            }
        }


        private int GetBookIdFromBorrowing(int borrowId)
        {
            string query = $"SELECT book_id FROM borrowings WHERE borrow_id = {borrowId}";
            return Convert.ToInt32(dbHelper.ExecuteScalar(query));
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadBorrowings();
            LoadMembersCombo();
            LoadBooksCombo();
        }




        private void DeleteAllBorrowings()
        {
            try
            {
                DialogResult result = MessageBox.Show("هل أنت متأكد أنك تريد حذف جميع سجلات الاستعارات نهائيًا؟",
                                                      "تحذير",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM borrowings";
                    int rowsAffected = dbHelper.ExecuteNonQuery(deleteQuery);

                    LoadBorrowings();

                    MessageBox.Show($"تم حذف {rowsAffected} سجل(ات) من جدول الاستعارات.",
                                    "نجاح",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حذف البيانات: " + ex.Message,
                                "خطأ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        private void ClearBorrowingsGrid()
        {
            if (dataGridViewBorrowings.DataSource != null)
            {
                dataGridViewBorrowings.DataSource = null; 
            }
            else
            {
                dataGridViewBorrowings.Rows.Clear();
            }

            lblBorrowInfo.Text = "---";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteAllBorrowings();
        }
    }
}