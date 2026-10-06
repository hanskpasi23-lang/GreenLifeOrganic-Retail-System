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
    public partial class Checkout : Form
    {
        private int userId;
        private Dictionary<int, int> cart;
        private decimal grandTotal = 0;

        public Checkout(int userId, Dictionary<int, int> cartItems)
        {
            InitializeComponent();
            this.userId = userId;
            this.cart = cartItems;
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            LoadCartDetails();
        }
        private void LoadCartDetails()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total");
            dt.Columns.Add("Discount");
            dt.Columns.Add("FinalPrice");

            grandTotal = 0;

            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                foreach (var item in cart)
                {

                    string query = "SELECT Name, Price, Discount FROM Products WHERE ProductID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", item.Key);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["Name"].ToString();
                                decimal originalPrice = Convert.ToDecimal(reader["Price"]);
                                decimal discountPercent = Convert.ToDecimal(reader["Discount"]);
                                int qty = item.Value;

                                decimal discountAmount = originalPrice * (discountPercent / 100);
                                decimal finalPrice = originalPrice - discountAmount;
                                decimal lineTotal = finalPrice * qty;
                                grandTotal += lineTotal;


                                dt.Rows.Add(item.Key, name, originalPrice, qty, lineTotal, discountPercent + "%", finalPrice);
                            }
                        }
                    }
                }
            }

            dgvCart.DataSource = dt;
            lblTotal.Text = "Total Amount: $" + grandTotal.ToString("0.00");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {

                    string orderQuery = @"INSERT INTO Orders (CustomerID, TotalAmount, Status) OUTPUT INSERTED.OrderID VALUES (@cid, @total, 'Pending')";

                    int newOrderId;
                    using (SqlCommand cmd = new SqlCommand(orderQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@cid", userId);
                        cmd.Parameters.AddWithValue("@total", grandTotal);
                        newOrderId = (int)cmd.ExecuteScalar();
                    }


                    foreach (var item in cart)
                    {
                        int pId = item.Key;
                        int qty = item.Value;


                        decimal currentPrice = 0;


                        string detailQuery = @"INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)  VALUES (@oid, @pid, @qty,(SELECT Price - (Price * (Discount / 100.0)) FROM Products WHERE ProductID=@pid))";
                        using (SqlCommand cmd = new SqlCommand(detailQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@oid", newOrderId);
                            cmd.Parameters.AddWithValue("@pid", pId);
                            cmd.Parameters.AddWithValue("@qty", qty);
                            cmd.ExecuteNonQuery();
                        }


                        string stockQuery = "UPDATE Products SET StockQuantity = StockQuantity - @qty WHERE ProductID = @pid";
                        using (SqlCommand cmd = new SqlCommand(stockQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@qty", qty);
                            cmd.Parameters.AddWithValue("@pid", pId);
                            cmd.ExecuteNonQuery();
                        }
                    }


                    transaction.Commit();

                    MessageBox.Show("Order Placed Successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                    MessageBox.Show("Order Failed. No charges made. Error: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.", "Input Error");
                return;
            }

            
            int productId = Convert.ToInt32(dgvCart.SelectedRows[0].Cells["ProductID"].Value);


            DialogResult result = MessageBox.Show("Are you sure you want to remove this item?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                if (cart.ContainsKey(productId))
                {
                    cart.Remove(productId);

                  
                    LoadCartDetails();

                   
                    if (cart.Count == 0)
                    {
                        MessageBox.Show("Cart is now empty.");
                        this.Close();
                    }
                }
            }
        }
    }
}
