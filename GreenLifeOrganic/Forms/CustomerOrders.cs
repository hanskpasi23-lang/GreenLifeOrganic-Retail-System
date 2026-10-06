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
    public partial class CustomerOrders : Form
    {
        private int currentUserId;

        public CustomerOrders(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
            LoadMyOrders();
        }
        private void LoadMyOrders()
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {

                string query = "SELECT OrderID, OrderDate, TotalAmount, Status FROM Orders WHERE CustomerID = @cid ORDER BY OrderDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@cid", this.currentUserId);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMyOrders.DataSource = dt;
            }
        }

        private void dgvMyOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(dgvMyOrders.Rows[e.RowIndex].Cells["OrderID"].Value);
                ShowOrderDetails(orderId);
            }
        }
        private void ShowOrderDetails(int orderId)
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                string query = @"
                    SELECT p.Name, d.Quantity, d.UnitPrice 
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
                    details += $"{row["Name"]} (x{row["Quantity"]}) - ${row["UnitPrice"]}\n";
                }

                MessageBox.Show(details, "Order Contents", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
