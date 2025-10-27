namespace LibraryManagementSystem
{
    partial class Form1
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.booksMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.membersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.LightBlue;
            this.mainMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksMenu,
            this.membersMenu,
            this.borrowMenu,
            this.dashboardMenu,
            this.exitMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1167, 27);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // booksMenu
            // 
            this.booksMenu.Name = "booksMenu";
            this.booksMenu.Size = new System.Drawing.Size(101, 23);
            this.booksMenu.Text = "📚ادارة الكتب";
            this.booksMenu.Click += new System.EventHandler(this.booksMenu_Click);
            // 
            // membersMenu
            // 
            this.membersMenu.Name = "membersMenu";
            this.membersMenu.Size = new System.Drawing.Size(123, 23);
            this.membersMenu.Text = "👥 إدارة الأعضاء";
            this.membersMenu.Click += new System.EventHandler(this.membersMenu_Click);
            // 
            // borrowMenu
            // 
            this.borrowMenu.Name = "borrowMenu";
            this.borrowMenu.Size = new System.Drawing.Size(136, 23);
            this.borrowMenu.Text = "📖 إدارة الاستعارات";
            this.borrowMenu.Click += new System.EventHandler(this.borrowMenu_Click);
            // 
            // dashboardMenu
            // 
            this.dashboardMenu.Name = "dashboardMenu";
            this.dashboardMenu.Size = new System.Drawing.Size(112, 23);
            this.dashboardMenu.Text = "📊 لوحة التحكم";
            this.dashboardMenu.Click += new System.EventHandler(this.dashboardMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(76, 23);
            this.exitMenu.Text = "🚪 خروج";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.Lavender;
            this.welcomePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomePanel.Controls.Add(this.lblSubTitle);
            this.welcomePanel.Controls.Add(this.lblWelcome);
            this.welcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomePanel.Location = new System.Drawing.Point(0, 27);
            this.welcomePanel.Margin = new System.Windows.Forms.Padding(4);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(1167, 711);
            this.welcomePanel.TabIndex = 1;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSubTitle.Font = new System.Drawing.Font("Arial", 11F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblSubTitle.Location = new System.Drawing.Point(0, 638);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(1165, 71);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "اختر من القائمة أعلاه لبدء استخدام النظام\nSelect from the menu above to start";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Sienna;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1165, 709);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "مرحباً بك في نظام إدارة المكتبة\nWelcome to Library Management System";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 738);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة المكتبة - Library Management System";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.welcomePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem booksMenu;
        private System.Windows.Forms.ToolStripMenuItem membersMenu;
        private System.Windows.Forms.ToolStripMenuItem borrowMenu;
        private System.Windows.Forms.ToolStripMenuItem dashboardMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblWelcome;
    }
}