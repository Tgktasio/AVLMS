using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Generators;

namespace AVLMS
{
    public partial class RegisterForm : Form
    {
        string connectionString = "server=localhost;user=root;database=AlvinLMSdb;port=3306;password=YOUR_PASSWORD;";

        public RegisterForm()
        {
            InitializeComponent();
        }

      

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@username", username);
                    object Password = null;
                    cmd.Parameters.AddWithValue("@password", Password);
                  
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!");
                    this.Close(); 
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
