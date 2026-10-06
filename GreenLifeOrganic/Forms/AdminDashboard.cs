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
using System.IO;

namespace GreenLifeOrganic
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadProducts();
            CheckForLowStock();
        }
        private void LoadProducts()
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                string query = "SELECT * FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Products (Name, Category, Price, StockQuantity, Supplier, Discount) VALUES (@n, @c, @p, @s, @sup, @d)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", txtName.Text);
                        cmd.Parameters.AddWithValue("@c", txtCategory.Text);
                        cmd.Parameters.AddWithValue("@p", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@s", int.Parse(txtStock.Text));
                        cmd.Parameters.AddWithValue("@sup", txtSupplier.Text);
                        cmd.Parameters.AddWithValue("@d", decimal.Parse(txtDiscount.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product Added Successfully!");

                        LoadProducts();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblProductID.Text == "" || !ValidateInputs())
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Products SET Name=@n, Category=@c, Price=@p, StockQuantity=@s, Supplier=@sup, Discount=@d WHERE ProductID=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(lblProductID.Text));
                        cmd.Parameters.AddWithValue("@n", txtName.Text);
                        cmd.Parameters.AddWithValue("@c", txtCategory.Text);
                        cmd.Parameters.AddWithValue("@p", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@s", int.Parse(txtStock.Text));
                        cmd.Parameters.AddWithValue("@sup", txtSupplier.Text);
                        cmd.Parameters.AddWithValue("@d", decimal.Parse(txtDiscount.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product Updated Successfully!");

                        LoadProducts();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblProductID.Text == "")
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }


            if (MessageBox.Show("Are you sure you want to delete this?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Products WHERE ProductID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(lblProductID.Text));
                        cmd.ExecuteNonQuery();

                        LoadProducts();
                        ClearFields();
                    }
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                lblProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtStock.Text = row.Cells["StockQuantity"].Value.ToString();
                txtSupplier.Text = row.Cells["Supplier"].Value.ToString();
                txtDiscount.Text = row.Cells["Discount"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtSupplier.Clear();
            txtDiscount.Clear();
            lblProductID.Text = "";
        }
        private bool ValidateInputs()
        {
            decimal price;
            int stock;

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Name and Price are required.");
                return false;
            }
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Price must be a valid number.");
                return false;
            }
            if (!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Stock must be a whole number.");
                return false;
            }
            return true;
        }
        private void CheckForLowStock()
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {

                string query = "SELECT Name, StockQuantity FROM Products WHERE StockQuantity < 5";

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            string lowStockMessage = "";

                            while (reader.Read())
                            {
                                string name = reader["Name"].ToString();
                                string qty = reader["StockQuantity"].ToString();
                                lowStockMessage += $"- {name}: Only {qty} left\n";
                            }


                            if (!string.IsNullOrEmpty(lowStockMessage))
                            {
                                MessageBox.Show("WARNING: The following items are running low on stock:\n\n" + lowStockMessage,
                                                "Inventory Alert",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking stock: " + ex.Message);
                }
            }
        }

        private void linkSalesRep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {

                string query = "SELECT COUNT(OrderID) AS TotalOrders, ISNULL(SUM(TotalAmount), 0) AS TotalRevenue FROM Orders";

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                int totalOrders = Convert.ToInt32(reader["TotalOrders"]);
                                decimal totalRevenue = Convert.ToDecimal(reader["TotalRevenue"]);


                                string report = "=== SALES REPORT ===\n\n";
                                report += $"Total Orders Placed: {totalOrders}\n";
                                report += $"Total Revenue: ${totalRevenue:N2}\n";


                                MessageBox.Show(report, "Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating report: " + ex.Message);
                }
            }
        }

        private void linkMngOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminOrder orderForm = new AdminOrder();
            orderForm.Show();
        }

        private void linkMngCus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminCustomer adcus = new AdminCustomer();
            adcus.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void linkStockCSV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvProducts.Rows.Count == 0)
            {
                MessageBox.Show("No stock data available to export.", "Info");
                return;
            }

            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "GreenLife_Stock_Report.csv";
            sfd.Title = "Save Stock Report";

            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    string csvOutput = "Product ID,Name,Category,Price,Stock Quantity,Supplier,Discount\n";

                    
                    foreach (DataGridViewRow row in dgvProducts.Rows)
                    {
                       
                        if (!row.IsNewRow)
                        {
                            string id = row.Cells["ProductID"].Value?.ToString() ?? "";
                            string name = row.Cells["Name"].Value?.ToString() ?? "";
                            string cat = row.Cells["Category"].Value?.ToString() ?? "";
                            string price = row.Cells["Price"].Value?.ToString() ?? "0.00";
                            string stock = row.Cells["StockQuantity"].Value?.ToString() ?? "0";
                            string supplier = row.Cells["Supplier"].Value?.ToString() ?? "";

                           
                            string discount = row.Cells["Discount"].Value?.ToString() ?? "0";

                           
                            csvOutput += $"{id},{name},{cat},{price},{stock},{supplier},{discount}\n";
                        }
                    }

                   
                    File.WriteAllText(sfd.FileName, csvOutput);

                    MessageBox.Show("Stock report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
