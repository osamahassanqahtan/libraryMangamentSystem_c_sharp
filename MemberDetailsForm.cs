using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MemberDetailsForm : Form
    {
        private DatabaseHelper dbHelper;
        private int memberId;
        private bool isEditMode;

        public MemberDetailsForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            isEditMode = false;
        }

        public MemberDetailsForm(int id) : this()
        {
            memberId = id;
            isEditMode = true;
            this.Text = "✏️ تعديل بيانات العضو";
            this.lblHeader.Text = "تعديل بيانات العضو";
        }

        private void MemberDetailsForm_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                LoadMemberData();
            }
            txtName.Focus();
        }

        private void LoadMemberData()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string query = $"SELECT * FROM members WHERE member_id = {memberId}";
                DataTable result = dbHelper.ExecuteQuery(query);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    txtName.Text = row["name"].ToString();
                    txtPhone.Text = row["phone"].ToString();
                    txtEmail.Text = row["email"].ToString();
                }
                else
                {
                    MessageBox.Show("❌ لم يتم العثور على العضو", "خطأ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ خطأ في تحميل بيانات العضو:\n{ex.Message}", "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return true; 

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }
            catch
            {
                return false;
            }
        }

        private bool ValidateInput()
        {
            // التحقق من الاسم
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("⚠️ يرجى إدخال اسم العضو", "حقل مطلوب",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // التحقق من البريد الإلكتروني
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("⚠️ يرجى إدخال بريد إلكتروني صحيح", "قيمة غير صحيحة",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
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

                // تجهيز البيانات
                string name = txtName.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();

                string query;
                if (isEditMode)
                {
                    query = $@"UPDATE members SET 
                             name = '{EscapeSql(name)}', 
                             phone = '{EscapeSql(phone)}', 
                             email = '{EscapeSql(email)}'
                             WHERE member_id = {memberId}";
                }
                else
                {
                    query = $@"INSERT INTO members (name, phone, email) 
                             VALUES ('{EscapeSql(name)}', '{EscapeSql(phone)}', '{EscapeSql(email)}')";
                }

                int rowsAffected = dbHelper.ExecuteNonQuery(query);

                if (rowsAffected > 0)
                {
                    string successMessage = isEditMode ?
                        "✅ تم تعديل بيانات العضو بنجاح" :
                        "✅ تم إضافة العضو بنجاح";

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

        // دالة للهروب من الأحرف الخاصة في SQL
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
    }
}