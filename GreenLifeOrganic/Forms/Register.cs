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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnSubmitRegister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtRegUsername.Text) ||
                string.IsNullOrWhiteSpace(txtRegPassword.Text) ||
                string.IsNullOrWhiteSpace(txtRegName.Text))
            {
                MessageBox.Show("Username, Password, and Full Name are required.");
                return;
            }

            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @u";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@u", txtRegUsername.Text.Trim());
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This username is already taken. Please choose another.");
                            return;
                        }
                    }


                    string query = @"INSERT INTO Users (Username, Password, Role, FullName, Email, Phone, Address) 
                                     VALUES (@u, @p, 'Customer', @fn,@em, @ph, @addr)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", txtRegUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@p", txtRegPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@fn", txtRegName.Text.Trim());
                        cmd.Parameters.AddWithValue("@em", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@ph", txtRegPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@addr", txtRegAddress.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration Successful! You can now login.");


                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering: " + ex.Message);
                }
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
