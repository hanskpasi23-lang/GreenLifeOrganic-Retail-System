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
    public partial class AdminOrder : Form
    {
        public AdminOrder()
        {
            InitializeComponent();
            LoadOrders();
        }
        private void LoadOrders()
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {

                string query = @"
                    SELECT o.OrderID, u.FullName, o.OrderDate, o.TotalAmount, o.Status 
                    FROM Orders o
                    JOIN Users u ON o.CustomerID = u.UserID
                    ORDER BY o.OrderDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOrders.DataSource = dt;
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrders.Rows[e.RowIndex];
                lblOrderId.Text = row.Cells["OrderID"].Value.ToString();


                string currentStatus = row.Cells["Status"].Value.ToString();
                int index = cmbStatus.FindStringExact(currentStatus);
                if (index != -1)
                {
                    cmbStatus.SelectedItem = currentStatus;
                }
                else
                {
                    cmbStatus.SelectedIndex = -1;
                    cmbStatus.Text = currentStatus;
                }
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblOrderId.Text))
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Please select a new status.");
                return;
            }

            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Orders SET Status = @status WHERE OrderID = @oid";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@oid", int.Parse(lblOrderId.Text));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Order Status Updated!");
                        LoadOrders();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblOrderId.Text)) return;

            int orderId = int.Parse(lblOrderId.Text);

            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                string query = @"
                    SELECT p.Name, d.Quantity, d.UnitPrice, (d.Quantity * d.UnitPrice) as SubTotal
                    FROM OrderDetails d
                    JOIN Products p ON d.ProductID = p.ProductID
                    WHERE d.OrderID = @oid";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@oid", orderId);

                DataTable dt = new DataTable();
                da.Fill(dt);


                string details = $"--- Items in Order #{orderId} ---\n\n";
                foreach (DataRow row in dt.Rows)
                {
                    details += $"{row["Name"]} x {row["Quantity"]} = ${row["SubTotal"]}\n";
                }
                MessageBox.Show(details, "Order Details");
            }
        }

        private void AdminOrder_Load(object sender, EventArgs e)
        {

            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Shipped");
            cmbStatus.Items.Add("Delivered");

            LoadOrders();
        }

        private void linkExportCSV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (dgvOrders.Rows.Count == 0)
            {
                MessageBox.Show("No order records to export.", "Info");
                return;
            }

           
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "GreenLife_Sales_Report.csv";
            sfd.Title = "Save Sales Report";

            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    string csvOutput = "Order ID,Customer Name,Date,Total Amount,Status\n";

                    
                    foreach (DataGridViewRow row in dgvOrders.Rows)
                    {
                        
                        if (!row.IsNewRow)
                        {
                            string id = row.Cells["OrderID"].Value?.ToString() ?? "";
                            string name = row.Cells["FullName"].Value?.ToString() ?? ""; 
                            string date = row.Cells["OrderDate"].Value?.ToString() ?? "";
                            string total = row.Cells["TotalAmount"].Value?.ToString() ?? "0.00";
                            string status = row.Cells["Status"].Value?.ToString() ?? "";

                            
                            csvOutput += $"{id},{name},{date},{total},{status}\n";
                        }
                    }

                    
                    File.WriteAllText(sfd.FileName, csvOutput);

                    MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
