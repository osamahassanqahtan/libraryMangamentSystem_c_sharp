using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BooksForm : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable booksTable;

        public BooksForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string query = @"
                    SELECT 
                        book_id as 'رقم_الكتاب',
                        title as 'العنوان', 
                        author as 'المؤلف', 
                        category as 'التصنيف', 
                        quantity as 'الكمية', 
                        price as 'السعر'
                    FROM books 
                    ORDER BY book_id";

                booksTable = dbHelper.ExecuteQuery(query);
                dataGridViewBooks.DataSource = booksTable;

               
                if (dataGridViewBooks.Columns.Count > 0)
                {
                    dataGridViewBooks.Columns["رقم_الكتاب"].Width = 80;
                    dataGridViewBooks.Columns["الكمية"].Width = 70;
                    dataGridViewBooks.Columns["السعر"].Width = 80;
                    dataGridViewBooks.Columns["السعر"].DefaultCellStyle.Format = "C2";
                    dataGridViewBooks.Columns["السعر"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridViewBooks.Columns["الكمية"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                Text = $"📚 إدارة الكتب ({booksTable.Rows.Count} كتاب)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"❌ خطأ في تحميل بيانات الكتب:\n{ex.Message}",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BookDetailsForm detailsForm = new BookDetailsForm();
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                    MessageBox.Show("✅ تم إضافة الكتاب بنجاح", "نجاح",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ خطأ في إضافة الكتاب: {ex.Message}", "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠️ يرجى اختيار كتاب للتعديل", "تنبيه",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int bookId = Convert.ToInt32(dataGridViewBooks.SelectedRows[0].Cells["رقم_الكتاب"].Value);
                BookDetailsForm detailsForm = new BookDetailsForm(bookId);
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    LoadBooks();
                    MessageBox.Show("✅ تم تعديل الكتاب بنجاح", "نجاح",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ خطأ في تعديل الكتاب: {ex.Message}", "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠️ يرجى اختيار كتاب للحذف", "تنبيه",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int bookId = Convert.ToInt32(dataGridViewBooks.SelectedRows[0].Cells["رقم_الكتاب"].Value);
                string bookTitle = dataGridViewBooks.SelectedRows[0].Cells["العنوان"].Value.ToString();

                string checkBorrowQuery = $"SELECT COUNT(*) FROM borrowings WHERE book_id = {bookId} AND status = 'مستعار'";
                int activeBorrowings = Convert.ToInt32(dbHelper.ExecuteScalar(checkBorrowQuery));

                if (activeBorrowings > 0)
                {
                    MessageBox.Show("❌ لا يمكن حذف الكتاب لأنه مستعار حالياً", "خطأ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"⚠️ هل أنت متأكد من حذف الكتاب:\n\"{bookTitle}\"؟\n\nهذا الإجراء لا يمكن التراجع عنه.",
                    "تأكيد الحذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = $"DELETE FROM books WHERE book_id = {bookId}";
                    int rowsAffected = dbHelper.ExecuteNonQuery(deleteQuery);

                    if (rowsAffected > 0)
                    {
                        LoadBooks();
                        MessageBox.Show("✅ تم حذف الكتاب بنجاح", "نجاح",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ خطأ في حذف الكتاب: {ex.Message}", "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (booksTable == null)
                return;

            if (string.IsNullOrEmpty(searchText))
            {
                dataGridViewBooks.DataSource = booksTable;
            }
            else
            {
                var filteredRows = booksTable.AsEnumerable()
                    .Where(row =>
                        row.Field<string>("العنوان").Contains(searchText) ||
                        row.Field<string>("المؤلف").Contains(searchText) ||
                        row.Field<string>("التصنيف").Contains(searchText));

                if (filteredRows.Any())
                {
                    dataGridViewBooks.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    dataGridViewBooks.DataSource = booksTable.Clone();
                }
            }

            
            int resultCount = (dataGridViewBooks.DataSource as DataTable)?.Rows.Count ?? 0;
            Text = $"📚 إدارة الكتب ({resultCount} نتيجة)";
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadBooks();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}