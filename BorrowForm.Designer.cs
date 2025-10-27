namespace LibraryManagementSystem
{
    partial class BorrowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpNewBorrow = new System.Windows.Forms.GroupBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.cmbMembers = new System.Windows.Forms.ComboBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.grpReturn = new System.Windows.Forms.GroupBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblBorrowInfo = new System.Windows.Forms.Label();
            this.lblSelectedBorrow = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewBorrowings = new System.Windows.Forms.DataGridView();
            this.BtnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpNewBorrow.SuspendLayout();
            this.grpReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowings)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNewBorrow
            // 
            this.grpNewBorrow.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grpNewBorrow.Controls.Add(this.dtpBorrowDate);
            this.grpNewBorrow.Controls.Add(this.lblBorrowDate);
            this.grpNewBorrow.Controls.Add(this.cmbBooks);
            this.grpNewBorrow.Controls.Add(this.lblBook);
            this.grpNewBorrow.Controls.Add(this.cmbMembers);
            this.grpNewBorrow.Controls.Add(this.lblMember);
            this.grpNewBorrow.Controls.Add(this.btnBorrow);
            this.grpNewBorrow.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.grpNewBorrow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpNewBorrow.Location = new System.Drawing.Point(23, 25);
            this.grpNewBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.grpNewBorrow.Name = "grpNewBorrow";
            this.grpNewBorrow.Padding = new System.Windows.Forms.Padding(4);
            this.grpNewBorrow.Size = new System.Drawing.Size(552, 222);
            this.grpNewBorrow.TabIndex = 0;
            this.grpNewBorrow.TabStop = false;
            this.grpNewBorrow.Text = "استعارة جديدة";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowDate.Location = new System.Drawing.Point(98, 129);
            this.dtpBorrowDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(310, 27);
            this.dtpBorrowDate.TabIndex = 6;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(443, 135);
            this.lblBorrowDate.Margin = new System.Windows.Forms.Padding(5, 0, 4, 5);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(101, 19);
            this.lblBorrowDate.TabIndex = 5;
            this.lblBorrowDate.Text = "تاريخ الاستعارة:";
            this.lblBorrowDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBorrowDate.UseWaitCursor = true;
            // 
            // cmbBooks
            // 
            this.cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBooks.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(98, 66);
            this.cmbBooks.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(310, 27);
            this.cmbBooks.TabIndex = 4;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(443, 86);
            this.lblBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(49, 19);
            this.lblBook.TabIndex = 3;
            this.lblBook.Text = "الكتاب:";
            // 
            // cmbMembers
            // 
            this.cmbMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMembers.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbMembers.FormattingEnabled = true;
            this.cmbMembers.Location = new System.Drawing.Point(98, 31);
            this.cmbMembers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.Size = new System.Drawing.Size(310, 27);
            this.cmbMembers.TabIndex = 2;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(443, 37);
            this.lblMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(50, 19);
            this.lblMember.TabIndex = 1;
            this.lblMember.Text = "العضو:";
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.LightBlue;
            this.btnBorrow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBorrow.Location = new System.Drawing.Point(210, 172);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(140, 37);
            this.btnBorrow.TabIndex = 0;
            this.btnBorrow.Text = "تسجيل الاستعارة";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.BtnBorrow_Click);
            // 
            // grpReturn
            // 
            this.grpReturn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grpReturn.Controls.Add(this.dtpReturnDate);
            this.grpReturn.Controls.Add(this.lblReturnDate);
            this.grpReturn.Controls.Add(this.lblBorrowInfo);
            this.grpReturn.Controls.Add(this.lblSelectedBorrow);
            this.grpReturn.Controls.Add(this.btnReturn);
            this.grpReturn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.grpReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpReturn.Location = new System.Drawing.Point(583, 25);
            this.grpReturn.Margin = new System.Windows.Forms.Padding(4);
            this.grpReturn.Name = "grpReturn";
            this.grpReturn.Padding = new System.Windows.Forms.Padding(4);
            this.grpReturn.Size = new System.Drawing.Size(525, 222);
            this.grpReturn.TabIndex = 1;
            this.grpReturn.TabStop = false;
            this.grpReturn.Text = "إرجاع الكتاب";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(115, 103);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(233, 27);
            this.dtpReturnDate.TabIndex = 4;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(373, 111);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(92, 19);
            this.lblReturnDate.TabIndex = 3;
            this.lblReturnDate.Text = "تاريخ الإرجاع:";
            // 
            // lblBorrowInfo
            // 
            this.lblBorrowInfo.BackColor = System.Drawing.Color.White;
            this.lblBorrowInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBorrowInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBorrowInfo.Location = new System.Drawing.Point(74, 24);
            this.lblBorrowInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowInfo.Name = "lblBorrowInfo";
            this.lblBorrowInfo.Size = new System.Drawing.Size(291, 49);
            this.lblBorrowInfo.TabIndex = 2;
            this.lblBorrowInfo.Text = "---";
            this.lblBorrowInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectedBorrow
            // 
            this.lblSelectedBorrow.AutoSize = true;
            this.lblSelectedBorrow.Location = new System.Drawing.Point(373, 37);
            this.lblSelectedBorrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedBorrow.Name = "lblSelectedBorrow";
            this.lblSelectedBorrow.Size = new System.Drawing.Size(112, 19);
            this.lblSelectedBorrow.TabIndex = 1;
            this.lblSelectedBorrow.Text = "الاستعارة المحددة:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightGreen;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(175, 172);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 37);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "تسجيل الإرجاع";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightYellow;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(882, 275);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 37);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "🔄 تحديث البيانات";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // dataGridViewBorrowings
            // 
            this.dataGridViewBorrowings.AllowUserToAddRows = false;
            this.dataGridViewBorrowings.AllowUserToDeleteRows = false;
            this.dataGridViewBorrowings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBorrowings.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewBorrowings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBorrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowings.Location = new System.Drawing.Point(70, 320);
            this.dataGridViewBorrowings.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBorrowings.Name = "dataGridViewBorrowings";
            this.dataGridViewBorrowings.ReadOnly = true;
            this.dataGridViewBorrowings.RowHeadersVisible = false;
            this.dataGridViewBorrowings.RowHeadersWidth = 51;
            this.dataGridViewBorrowings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBorrowings.Size = new System.Drawing.Size(1000, 431);
            this.dataGridViewBorrowings.TabIndex = 3;
            this.dataGridViewBorrowings.SelectionChanged += new System.EventHandler(this.DataGridViewBorrowings_SelectionChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(86, 275);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(128, 38);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "تنضيف الواجهة\r\n";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "حذف السجلات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 814);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.dataGridViewBorrowings);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpReturn);
            this.Controls.Add(this.grpNewBorrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "📖 إدارة الاستعارات - Borrow Management";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            this.grpNewBorrow.ResumeLayout(false);
            this.grpNewBorrow.PerformLayout();
            this.grpReturn.ResumeLayout(false);
            this.grpReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewBorrow;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.ComboBox cmbMembers;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.GroupBox grpReturn;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblBorrowInfo;
        private System.Windows.Forms.Label lblSelectedBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewBorrowings;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button button1;
    }
}