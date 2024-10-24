using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AVLMS
{
    public partial class UserDashboard : Form
    {
        private string username;

        public UserDashboard(string loggedInUsername)
        {
            InitializeComponent();
            this.username = loggedInUsername;
            lblWelcome.Text = $"Welcome, {username}";
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            // Any initialization logic for user dashboard can go here.
        }

        private void BtnViewBooks_Click(object sender, EventArgs e)
        {
            // Show a form that lists all available books for the user to browse.
            ViewBooksForm viewBooksForm = new ViewBooksForm();
            viewBooksForm.ShowDialog();
        }

        private void BtnBorrowBooks_Click(object sender, EventArgs e)
        {
            // Show a form that allows users to select books for borrowing.
            BorrowBooksForm borrowBooksForm = new BorrowBooksForm(username);
            borrowBooksForm.ShowDialog();
        }

        private void BtnReturnBooks_Click(object sender, EventArgs e)
        {
            // Show a form for returning borrowed books.
            ReturnBooksForm returnBooksForm = new ReturnBooksForm(username);
            returnBooksForm.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Logout and return to the login screen.
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
