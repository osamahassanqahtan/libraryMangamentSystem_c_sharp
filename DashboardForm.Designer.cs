namespace LibraryManagementSystem
{
    partial class DashboardForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.cardActiveBorrowings = new System.Windows.Forms.Panel();
            this.lblActiveBorrowingsValue = new System.Windows.Forms.Label();
            this.lblActiveBorrowingsTitle = new System.Windows.Forms.Label();
            this.lblActiveBorrowingsSub = new System.Windows.Forms.Label();
            this.cardTotalMembers = new System.Windows.Forms.Panel();
            this.lblTotalMembersValue = new System.Windows.Forms.Label();
            this.lblTotalMembersTitle = new System.Windows.Forms.Label();
            this.lblTotalMembersSub = new System.Windows.Forms.Label();
            this.cardBorrowedBooks = new System.Windows.Forms.Panel();
            this.lblBorrowedBooksValue = new System.Windows.Forms.Label();
            this.lblBorrowedBooksTitle = new System.Windows.Forms.Label();
            this.lblBorrowedBooksSub = new System.Windows.Forms.Label();
            this.cardAvailableBooks = new System.Windows.Forms.Panel();
            this.lblAvailableBooksValue = new System.Windows.Forms.Label();
            this.lblAvailableBooksTitle = new System.Windows.Forms.Label();
            this.lblAvailableBooksSub = new System.Windows.Forms.Label();
            this.cardTotalBooks = new System.Windows.Forms.Panel();
            this.lblTotalBooksValue = new System.Windows.Forms.Label();
            this.lblTotalBooksTitle = new System.Windows.Forms.Label();
            this.lblTotalBooksSub = new System.Windows.Forms.Label();
            this.lblBorrowedBooks = new System.Windows.Forms.Label();
            this.dataGridViewBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.statsPanel.SuspendLayout();
            this.cardActiveBorrowings.SuspendLayout();
            this.cardTotalMembers.SuspendLayout();
            this.cardBorrowedBooks.SuspendLayout();
            this.cardAvailableBooks.SuspendLayout();
            this.cardTotalBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(23, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "لوحة تحكم المكتبة - Dashboard";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(933, 25);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 37);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "تحديث البيانات";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.LightGray;
            this.statsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statsPanel.Controls.Add(this.cardActiveBorrowings);
            this.statsPanel.Controls.Add(this.cardTotalMembers);
            this.statsPanel.Controls.Add(this.cardBorrowedBooks);
            this.statsPanel.Controls.Add(this.cardAvailableBooks);
            this.statsPanel.Controls.Add(this.cardTotalBooks);
            this.statsPanel.Location = new System.Drawing.Point(23, 86);
            this.statsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(1096, 184);
            this.statsPanel.TabIndex = 2;
            // 
            // cardActiveBorrowings
            // 
            this.cardActiveBorrowings.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cardActiveBorrowings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardActiveBorrowings.Controls.Add(this.lblActiveBorrowingsValue);
            this.cardActiveBorrowings.Controls.Add(this.lblActiveBorrowingsTitle);
            this.cardActiveBorrowings.Controls.Add(this.lblActiveBorrowingsSub);
            this.cardActiveBorrowings.Location = new System.Drawing.Point(770, 18);
            this.cardActiveBorrowings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardActiveBorrowings.Name = "cardActiveBorrowings";
            this.cardActiveBorrowings.Size = new System.Drawing.Size(175, 147);
            this.cardActiveBorrowings.TabIndex = 4;
            // 
            // lblActiveBorrowingsValue
            // 
            this.lblActiveBorrowingsValue.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblActiveBorrowingsValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblActiveBorrowingsValue.Location = new System.Drawing.Point(12, 55);
            this.lblActiveBorrowingsValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveBorrowingsValue.Name = "lblActiveBorrowingsValue";
            this.lblActiveBorrowingsValue.Size = new System.Drawing.Size(152, 49);
            this.lblActiveBorrowingsValue.TabIndex = 2;
            this.lblActiveBorrowingsValue.Text = "0";
            this.lblActiveBorrowingsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveBorrowingsTitle
            // 
            this.lblActiveBorrowingsTitle.AutoSize = true;
            this.lblActiveBorrowingsTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblActiveBorrowingsTitle.Location = new System.Drawing.Point(12, 18);
            this.lblActiveBorrowingsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveBorrowingsTitle.Name = "lblActiveBorrowingsTitle";
            this.lblActiveBorrowingsTitle.Size = new System.Drawing.Size(96, 19);
            this.lblActiveBorrowingsTitle.TabIndex = 1;
            this.lblActiveBorrowingsTitle.Text = "استعارات نشطة";
            this.lblActiveBorrowingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveBorrowingsSub
            // 
            this.lblActiveBorrowingsSub.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.lblActiveBorrowingsSub.ForeColor = System.Drawing.Color.DarkGray;
            this.lblActiveBorrowingsSub.Location = new System.Drawing.Point(12, 111);
            this.lblActiveBorrowingsSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveBorrowingsSub.Name = "lblActiveBorrowingsSub";
            this.lblActiveBorrowingsSub.Size = new System.Drawing.Size(152, 25);
            this.lblActiveBorrowingsSub.TabIndex = 0;
            this.lblActiveBorrowingsSub.Text = "لم يتم إرجاعها";
            this.lblActiveBorrowingsSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardTotalMembers
            // 
            this.cardTotalMembers.BackColor = System.Drawing.Color.LightYellow;
            this.cardTotalMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalMembers.Controls.Add(this.lblTotalMembersValue);
            this.cardTotalMembers.Controls.Add(this.lblTotalMembersTitle);
            this.cardTotalMembers.Controls.Add(this.lblTotalMembersSub);
            this.cardTotalMembers.Location = new System.Drawing.Point(583, 18);
            this.cardTotalMembers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardTotalMembers.Name = "cardTotalMembers";
            this.cardTotalMembers.Size = new System.Drawing.Size(175, 147);
            this.cardTotalMembers.TabIndex = 3;
            // 
            // lblTotalMembersValue
            // 
            this.lblTotalMembersValue.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalMembersValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalMembersValue.Location = new System.Drawing.Point(12, 55);
            this.lblTotalMembersValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMembersValue.Name = "lblTotalMembersValue";
            this.lblTotalMembersValue.Size = new System.Drawing.Size(152, 49);
            this.lblTotalMembersValue.TabIndex = 2;
            this.lblTotalMembersValue.Text = "0";
            this.lblTotalMembersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMembersTitle
            // 
            this.lblTotalMembersTitle.AutoSize = true;
            this.lblTotalMembersTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalMembersTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTotalMembersTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMembersTitle.Name = "lblTotalMembersTitle";
            this.lblTotalMembersTitle.Size = new System.Drawing.Size(98, 19);
            this.lblTotalMembersTitle.TabIndex = 1;
            this.lblTotalMembersTitle.Text = "إجمالي الأعضاء";
            this.lblTotalMembersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMembersSub
            // 
            this.lblTotalMembersSub.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.lblTotalMembersSub.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTotalMembersSub.Location = new System.Drawing.Point(12, 111);
            this.lblTotalMembersSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMembersSub.Name = "lblTotalMembersSub";
            this.lblTotalMembersSub.Size = new System.Drawing.Size(152, 25);
            this.lblTotalMembersSub.TabIndex = 0;
            this.lblTotalMembersSub.Text = "مسجلين في النظام";
            this.lblTotalMembersSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardBorrowedBooks
            // 
            this.cardBorrowedBooks.BackColor = System.Drawing.Color.LightCoral;
            this.cardBorrowedBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardBorrowedBooks.Controls.Add(this.lblBorrowedBooksValue);
            this.cardBorrowedBooks.Controls.Add(this.lblBorrowedBooksTitle);
            this.cardBorrowedBooks.Controls.Add(this.lblBorrowedBooksSub);
            this.cardBorrowedBooks.Location = new System.Drawing.Point(397, 18);
            this.cardBorrowedBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardBorrowedBooks.Name = "cardBorrowedBooks";
            this.cardBorrowedBooks.Size = new System.Drawing.Size(175, 147);
            this.cardBorrowedBooks.TabIndex = 2;
            // 
            // lblBorrowedBooksValue
            // 
            this.lblBorrowedBooksValue.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblBorrowedBooksValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBorrowedBooksValue.Location = new System.Drawing.Point(12, 55);
            this.lblBorrowedBooksValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowedBooksValue.Name = "lblBorrowedBooksValue";
            this.lblBorrowedBooksValue.Size = new System.Drawing.Size(152, 49);
            this.lblBorrowedBooksValue.TabIndex = 2;
            this.lblBorrowedBooksValue.Text = "0";
            this.lblBorrowedBooksValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorrowedBooksTitle
            // 
            this.lblBorrowedBooksTitle.AutoSize = true;
            this.lblBorrowedBooksTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblBorrowedBooksTitle.Location = new System.Drawing.Point(12, 18);
            this.lblBorrowedBooksTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowedBooksTitle.Name = "lblBorrowedBooksTitle";
            this.lblBorrowedBooksTitle.Size = new System.Drawing.Size(97, 19);
            this.lblBorrowedBooksTitle.TabIndex = 1;
            this.lblBorrowedBooksTitle.Text = "الكتب المستعارة";
            this.lblBorrowedBooksTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorrowedBooksSub
            // 
            this.lblBorrowedBooksSub.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.lblBorrowedBooksSub.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBorrowedBooksSub.Location = new System.Drawing.Point(12, 111);
            this.lblBorrowedBooksSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowedBooksSub.Name = "lblBorrowedBooksSub";
            this.lblBorrowedBooksSub.Size = new System.Drawing.Size(152, 25);
            this.lblBorrowedBooksSub.TabIndex = 0;
            this.lblBorrowedBooksSub.Text = "غير متاحة حالياً";
            this.lblBorrowedBooksSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardAvailableBooks
            // 
            this.cardAvailableBooks.BackColor = System.Drawing.Color.LightGreen;
            this.cardAvailableBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardAvailableBooks.Controls.Add(this.lblAvailableBooksValue);
            this.cardAvailableBooks.Controls.Add(this.lblAvailableBooksTitle);
            this.cardAvailableBooks.Controls.Add(this.lblAvailableBooksSub);
            this.cardAvailableBooks.Location = new System.Drawing.Point(210, 18);
            this.cardAvailableBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardAvailableBooks.Name = "cardAvailableBooks";
            this.cardAvailableBooks.Size = new System.Drawing.Size(175, 147);
            this.cardAvailableBooks.TabIndex = 1;
            // 
            // lblAvailableBooksValue
            // 
            this.lblAvailableBooksValue.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblAvailableBooksValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAvailableBooksValue.Location = new System.Drawing.Point(12, 55);
            this.lblAvailableBooksValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableBooksValue.Name = "lblAvailableBooksValue";
            this.lblAvailableBooksValue.Size = new System.Drawing.Size(152, 49);
            this.lblAvailableBooksValue.TabIndex = 2;
            this.lblAvailableBooksValue.Text = "0";
            this.lblAvailableBooksValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailableBooksTitle
            // 
            this.lblAvailableBooksTitle.AutoSize = true;
            this.lblAvailableBooksTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvailableBooksTitle.Location = new System.Drawing.Point(12, 18);
            this.lblAvailableBooksTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableBooksTitle.Name = "lblAvailableBooksTitle";
            this.lblAvailableBooksTitle.Size = new System.Drawing.Size(84, 19);
            this.lblAvailableBooksTitle.TabIndex = 1;
            this.lblAvailableBooksTitle.Text = "الكتب المتاحة";
            this.lblAvailableBooksTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailableBooksSub
            // 
            this.lblAvailableBooksSub.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.lblAvailableBooksSub.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAvailableBooksSub.Location = new System.Drawing.Point(12, 111);
            this.lblAvailableBooksSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableBooksSub.Name = "lblAvailableBooksSub";
            this.lblAvailableBooksSub.Size = new System.Drawing.Size(152, 25);
            this.lblAvailableBooksSub.TabIndex = 0;
            this.lblAvailableBooksSub.Text = "جاهزة للاستعارة";
            this.lblAvailableBooksSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardTotalBooks
            // 
            this.cardTotalBooks.BackColor = System.Drawing.Color.LightBlue;
            this.cardTotalBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalBooks.Controls.Add(this.lblTotalBooksValue);
            this.cardTotalBooks.Controls.Add(this.lblTotalBooksTitle);
            this.cardTotalBooks.Controls.Add(this.lblTotalBooksSub);
            this.cardTotalBooks.Location = new System.Drawing.Point(23, 18);
            this.cardTotalBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardTotalBooks.Name = "cardTotalBooks";
            this.cardTotalBooks.Size = new System.Drawing.Size(175, 147);
            this.cardTotalBooks.TabIndex = 0;
            // 
            // lblTotalBooksValue
            // 
            this.lblTotalBooksValue.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooksValue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalBooksValue.Location = new System.Drawing.Point(12, 55);
            this.lblTotalBooksValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBooksValue.Name = "lblTotalBooksValue";
            this.lblTotalBooksValue.Size = new System.Drawing.Size(152, 49);
            this.lblTotalBooksValue.TabIndex = 2;
            this.lblTotalBooksValue.Text = "0";
            this.lblTotalBooksValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalBooksValue.Click += new System.EventHandler(this.lblTotalBooksValue_Click);
            // 
            // lblTotalBooksTitle
            // 
            this.lblTotalBooksTitle.AutoSize = true;
            this.lblTotalBooksTitle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooksTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTotalBooksTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBooksTitle.Name = "lblTotalBooksTitle";
            this.lblTotalBooksTitle.Size = new System.Drawing.Size(82, 19);
            this.lblTotalBooksTitle.TabIndex = 1;
            this.lblTotalBooksTitle.Text = "إجمالي الكتب";
            this.lblTotalBooksTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalBooksSub
            // 
            this.lblTotalBooksSub.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.lblTotalBooksSub.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTotalBooksSub.Location = new System.Drawing.Point(12, 111);
            this.lblTotalBooksSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBooksSub.Name = "lblTotalBooksSub";
            this.lblTotalBooksSub.Size = new System.Drawing.Size(152, 25);
            this.lblTotalBooksSub.TabIndex = 0;
            this.lblTotalBooksSub.Text = "جميع الكتب في المكتبة";
            this.lblTotalBooksSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorrowedBooks
            // 
            this.lblBorrowedBooks.AutoSize = true;
            this.lblBorrowedBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBorrowedBooks.Location = new System.Drawing.Point(23, 295);
            this.lblBorrowedBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowedBooks.Name = "lblBorrowedBooks";
            this.lblBorrowedBooks.Size = new System.Drawing.Size(148, 24);
            this.lblBorrowedBooks.TabIndex = 3;
            this.lblBorrowedBooks.Text = "الكتب المستعارة حالياً";
            // 
            // dataGridViewBorrowedBooks
            // 
            this.dataGridViewBorrowedBooks.AllowUserToAddRows = false;
            this.dataGridViewBorrowedBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBorrowedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBorrowedBooks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBorrowedBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowedBooks.Location = new System.Drawing.Point(23, 332);
            this.dataGridViewBorrowedBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewBorrowedBooks.Name = "dataGridViewBorrowedBooks";
            this.dataGridViewBorrowedBooks.ReadOnly = true;
            this.dataGridViewBorrowedBooks.RowHeadersVisible = false;
            this.dataGridViewBorrowedBooks.RowHeadersWidth = 51;
            this.dataGridViewBorrowedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBorrowedBooks.Size = new System.Drawing.Size(1097, 431);
            this.dataGridViewBorrowedBooks.TabIndex = 4;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 814);
            this.Controls.Add(this.dataGridViewBorrowedBooks);
            this.Controls.Add(this.lblBorrowedBooks);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "📊 لوحة التحكم - Dashboard";
            this.statsPanel.ResumeLayout(false);
            this.cardActiveBorrowings.ResumeLayout(false);
            this.cardActiveBorrowings.PerformLayout();
            this.cardTotalMembers.ResumeLayout(false);
            this.cardTotalMembers.PerformLayout();
            this.cardBorrowedBooks.ResumeLayout(false);
            this.cardBorrowedBooks.PerformLayout();
            this.cardAvailableBooks.ResumeLayout(false);
            this.cardAvailableBooks.PerformLayout();
            this.cardTotalBooks.ResumeLayout(false);
            this.cardTotalBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel cardTotalBooks;
        private System.Windows.Forms.Label lblTotalBooksValue;
        private System.Windows.Forms.Label lblTotalBooksTitle;
        private System.Windows.Forms.Label lblTotalBooksSub;
        private System.Windows.Forms.Panel cardActiveBorrowings;
        private System.Windows.Forms.Label lblActiveBorrowingsValue;
        private System.Windows.Forms.Label lblActiveBorrowingsTitle;
        private System.Windows.Forms.Label lblActiveBorrowingsSub;
        private System.Windows.Forms.Panel cardTotalMembers;
        private System.Windows.Forms.Label lblTotalMembersValue;
        private System.Windows.Forms.Label lblTotalMembersTitle;
        private System.Windows.Forms.Label lblTotalMembersSub;
        private System.Windows.Forms.Panel cardBorrowedBooks;
        private System.Windows.Forms.Label lblBorrowedBooksValue;
        private System.Windows.Forms.Label lblBorrowedBooksTitle;
        private System.Windows.Forms.Label lblBorrowedBooksSub;
        private System.Windows.Forms.Panel cardAvailableBooks;
        private System.Windows.Forms.Label lblAvailableBooksValue;
        private System.Windows.Forms.Label lblAvailableBooksTitle;
        private System.Windows.Forms.Label lblAvailableBooksSub;
        private System.Windows.Forms.Label lblBorrowedBooks;
        private System.Windows.Forms.DataGridView dataGridViewBorrowedBooks;
    }
}