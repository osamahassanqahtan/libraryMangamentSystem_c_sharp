using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookDetailsForm : Form
    {
        private DatabaseHelper dbHelper;
        private int bookId;
        private bool isEditMode;

        public BookDetailsForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            isEditMode = false;
        }

        public BookDetailsForm(int id) : this()
        {
            bookId = id;
            isEditMode = true;
            this.Text = "✏️ تعديل بيانات الكتاب";
            this.lblHeader.Text = "تعديل بيانات الكتاب";
        }

        private void BookDetailsForm_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                LoadBookData();
            }
            txtTitle.Focus();
        }

        private void LoadBookData()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string query = $"SELECT * FROM books WHERE book_id = {bookId}";
                DataTable result = dbHelper.ExecuteQuery(query);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    txtTitle.Text = row["title"].ToString();
                    txtAuthor.Text = row["author"].ToString();
                    txtCategory.Text = row["category"].ToString();
                    numQuantity.Value = Convert.ToInt32(row["quantity"]);
                    txtPrice.Text = Convert.ToDecimal(row["price"]).ToString("F2");
                }
                else
                {
                    MessageBox.Show("❌ لم يتم العثور على الكتاب", "خطأ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ خطأ في تحميل بيانات الكتاب:\n{ex.Message}", "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("⚠️ يرجى إدخال عنوان الكتاب", "حقل مطلوب",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("⚠️ يرجى إدخال اسم المؤلف", "حقل مطلوب",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("⚠️ يرجى إدخال سعر الكتاب", "حقل مطلوب",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("⚠️ يرجى إدخال سعر صحيح (أكبر من أو يساوي صفر)", "قيمة غير صحيحة",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                txtPrice.SelectAll();
                return false;
            }

            return true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                string title = txtTitle.Text.Trim();
                string author = txtAuthor.Text.Trim();
                string category = txtCategory.Text.Trim();
                int quantity = (int)numQuantity.Value;
                decimal price = decimal.Parse(txtPrice.Text);

                string query;
                if (isEditMode)
                {
                    query = $@"UPDATE books SET 
                             title = '{EscapeSql(title)}', 
                             author = '{EscapeSql(author)}', 
                             category = '{EscapeSql(category)}', 
                             quantity = {quantity}, 
                             price = {price.ToString(CultureInfo.InvariantCulture)} 
                             WHERE book_id = {bookId}";
                }
                else
                {
                    query = $@"INSERT INTO books (title, author, category, quantity, price) 
                             VALUES ('{EscapeSql(title)}', '{EscapeSql(author)}', '{EscapeSql(category)}', 
                                     {quantity}, {price.ToString(CultureInfo.InvariantCulture)})";
                }

                int rowsAffected = dbHelper.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    string successMessage = isEditMode ?
                        "✅ تم تعديل بيانات الكتاب بنجاح" :
                        "✅ تم إضافة الكتاب بنجاح";

                    MessageBox.Show(successMessage, "نجاح",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("❌ لم يتم حفظ البيانات", "تنبيه",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ خطأ في حفظ البيانات:\n{ex.Message}", "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private string EscapeSql(string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Replace("'", "''");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtPrice.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}