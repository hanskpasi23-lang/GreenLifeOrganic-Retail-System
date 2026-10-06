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
    public partial class UserProfile : Form
    {
        private int userId;

        public UserProfile(int id)
        {
            InitializeComponent();
            this.userId = id;
            LoadUserData();
        }
        private void LoadUserData()
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT FullName, Address, Phone, Password FROM Users WHERE UserID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", this.userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFullName.Text = reader["FullName"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            txtPhone.Text = reader["Phone"].ToString();
                            txtPassword.Text = reader["Password"].ToString();
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Users SET FullName=@fn, Address=@addr, Phone=@ph, Password=@pass WHERE UserID=@id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fn", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@addr", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@ph", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@id", this.userId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Profile Updated Successfully!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
