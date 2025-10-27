using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MembersForm : Form
    {
        private DatabaseHelper dbHelper;
        private DataTable membersTable;

        public MembersForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void LoadMembers()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string query = @"
                    SELECT 
                        member_id as 'رقم_العضو',
                        name as 'الاسم', 
                        phone as 'الهاتف', 
                        email as 'البريد_الإلكتروني'
                    FROM members 
                    ORDER BY member_id";

                membersTable = dbHelper.ExecuteQuery(query);
                dataGridViewMembers.DataSource = membersTable;


                if (dataGridViewMembers.Columns.Count > 0)
                {
                    dataGridViewMembers.Columns["رقم_العضو"].Width = 80;
                    dataGridViewMembers.Columns["الهاتف"].Width = 120;
                    dataGridViewMembers.Columns["البريد_الإلكتروني"].Width = 200;
                }

                // تحديث العنوان بعدد الأعضاء
                Text = $"👥 إدارة الأعضاء ({membersTable.Rows.Count} عضو)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"❌ خطأ في تحميل بيانات الأعضاء:\n{ex.Message}",
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
                MemberDetailsForm detailsForm = new MemberDetailsForm();
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMembers();
                    MessageBox.Show("✅ تم إضافة العضو بنجاح", "نجاح",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ خطأ في إضافة العضو: {ex.Message}", "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠️ يرجى اختيار عضو للتعديل", "تنبيه",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int memberId = Convert.ToInt32(dataGridViewMembers.SelectedRows[0].Cells["رقم_العضو"].Value);
                MemberDetailsForm detailsForm = new MemberDetailsForm(memberId);
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    LoadMembers();
                    MessageBox.Show("✅ تم تعديل العضو بنجاح", "نجاح",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ خطأ في تعديل العضو: {ex.Message}", "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMembers.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠️ يرجى اختيار عضو للحذف", "تنبيه",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int memberId = Convert.ToInt32(dataGridViewMembers.SelectedRows[0].Cells["رقم_العضو"].Value);
                string memberName = dataGridViewMembers.SelectedRows[0].Cells["الاسم"].Value.ToString();

                // التحقق مما إذا كان العضو لديه استعارات نشطة
                string checkBorrowQuery = $"SELECT COUNT(*) FROM borrowings WHERE member_id = {memberId} AND status = 'مستعار'";
                int activeBorrowings = Convert.ToInt32(dbHelper.ExecuteScalar(checkBorrowQuery));

                if (activeBorrowings > 0)
                {
                    MessageBox.Show("❌ لا يمكن حذف العضو لأنه لديه كتب مستعارة حالياً", "خطأ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"⚠️ هل أنت متأكد من حذف العضو:\n\"{memberName}\"؟\n\nهذا الإجراء لا يمكن التراجع عنه.",
                    "تأكيد الحذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = $"DELETE FROM members WHERE member_id = {memberId}";
                    int rowsAffected = dbHelper.ExecuteNonQuery(deleteQuery);

                    if (rowsAffected > 0)
                    {
                        LoadMembers();
                        MessageBox.Show("✅ تم حذف العضو بنجاح", "نجاح",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ خطأ في حذف العضو: {ex.Message}", "خطأ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (membersTable == null) 
                return;
            

           // إذا كان فارغًا، نعيد كل الأعضاء(أي لا يوجد تصفية
            if (string.IsNullOrEmpty(searchText))
            {
                dataGridViewMembers.DataSource = membersTable;
            }
            else
            {

                var filteredRows = membersTable.AsEnumerable()
                    .Where(row =>
                        row.Field<string>("الاسم").Contains(searchText) ||
                        row.Field<string>("الهاتف").Contains(searchText) ||
                        row.Field<string>("البريد_الإلكتروني").Contains(searchText));

                                

                if (filteredRows.Any())
                {
                    dataGridViewMembers.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    dataGridViewMembers.DataSource = membersTable.Clone();
                }
            }
                               

            int resultCount = (dataGridViewMembers.DataSource as DataTable)?.Rows.Count ?? 0;

            Text = $"👥 إدارة الأعضاء ({resultCount} نتيجة)";
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadMembers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}