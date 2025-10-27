using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            

        }

        private void booksMenu_Click(object sender, EventArgs e)
        {
            ShowBooksForm();
        }

        private void membersMenu_Click(object sender, EventArgs e)
        {
            ShowMembersForm();
        }

        private void borrowMenu_Click(object sender, EventArgs e)
        {
            ShowBorrowForm();
        }

        private void dashboardMenu_Click(object sender, EventArgs e)
        {
            ShowDashboardForm();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowBooksForm()
        {
            BooksForm booksForm = new BooksForm();
            booksForm.ShowDialog();
        }

        private void ShowMembersForm()
        {
            MembersForm membersForm = new MembersForm();
            membersForm.ShowDialog();
        }

        private void ShowBorrowForm()
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.ShowDialog();
        }

        private void ShowDashboardForm()
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.ShowDialog();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}