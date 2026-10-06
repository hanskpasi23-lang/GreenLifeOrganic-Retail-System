using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLifeOrganic
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();


                    string query = "SELECT UserID, Role, FullName FROM Users WHERE Username = @u AND Password = @p";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                int userId = Convert.ToInt32(reader["UserID"]);
                                string role = reader["Role"].ToString();
                                string fullName = reader["FullName"].ToString();

                                MessageBox.Show($"Welcome, {fullName}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                if (role == "Admin")
                                {

                                    AdminDashboard adminForm = new AdminDashboard();
                                    adminForm.Show();
                                }
                                else if (role == "Customer")
                                {

                                    CustomerDashboard customerForm = new CustomerDashboard(userId);
                                    customerForm.Show();
                                }


                                this.Hide();
                            }
                            else
                            {

                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register regForm = new Register();
            regForm.ShowDialog();
        }
    }
}
    

