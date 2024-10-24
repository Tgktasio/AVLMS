using System;
using System.Windows.Forms;

namespace AVLMS
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooks manageBooksForm = new ManageBooks();
            manageBooksForm.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsersForm = new ManageUsers();
            manageUsersForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports();
            reportsForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
