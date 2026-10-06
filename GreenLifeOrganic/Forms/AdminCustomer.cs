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
    public partial class AdminCustomer : Form
    {
        public AdminCustomer()
        {
            InitializeComponent();
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {

                string query = "SELECT UserID, Username, FullName, Email, Phone, Address FROM Users WHERE Role = 'Customer'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];


                lblSelectedID.Text = row.Cells["UserID"].Value.ToString();
                txtCustName.Text = row.Cells["FullName"].Value.ToString();
                txtCustEmail.Text = row.Cells["Email"].Value.ToString();
                txtCustPhone.Text = row.Cells["Phone"].Value.ToString();
                txtCustAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblSelectedID.Text))
            {
                MessageBox.Show("Please select a customer from the list first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustName.Text))
            {
                MessageBox.Show("Full Name is required.");
                return;
            }

            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Users SET FullName = @fn,Email = @em,Phone = @ph,Address = @addr WHERE UserID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fn", txtCustName.Text.Trim());
                        cmd.Parameters.AddWithValue("@em", txtCustEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@ph", txtCustPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@addr", txtCustAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(lblSelectedID.Text));

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Customer Details Updated Successfully!");

                        LoadCustomers();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message);
                }
            }
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            lblSelectedID.Text = "";
            txtCustName.Clear();
            txtCustEmail.Clear();
            txtCustPhone.Clear();
            txtCustAddress.Clear();
        }
    }
}
