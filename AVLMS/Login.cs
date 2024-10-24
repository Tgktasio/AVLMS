using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AVLMS
{
    public partial class Login : Form
    {
        string connectionString = "server=localhost;user=root;database=AlvinLMSdb;port=3306;password=YOUR_PASSWORD;";

        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (ValidateLogin(username, password))
                {
                    if (username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "password")
                    {
                        MessageBox.Show("Admin login successful!");
                        OpenDashboard(new AdminDashboard());
                    }
                    else
                    {
                        MessageBox.Show("User login successful!");
                        OpenDashboard(new UserDashboard());
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to log in: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenDashboard(Form dashboard)
        {
            this.Hide();
            dashboard.FormClosed += (s, args) => this.Show(); 
            dashboard.ShowDialog();
        }

        private bool ValidateLogin(string username, string password)
        {
            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "password")
            {
                return true;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username=@username AND Password=@password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
