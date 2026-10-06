using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CustomerDashboard : Form
    {
        private int currentUserId;

        private Dictionary<int, int> shoppingCart = new Dictionary<int, int>();

        public CustomerDashboard(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
        }
        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome Customer #" + currentUserId;

            cmbSort.Items.Add("Default");
            cmbSort.Items.Add("Price: Low to High");
            cmbSort.Items.Add("Price: High to Low");
            cmbSort.SelectedIndex = 0;

            LoadAvailableProducts("");
        }
        private void LoadAvailableProducts(string searchTerm)
        {
            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {

                string query = "SELECT ProductID, Name, Category, Price, StockQuantity, Supplier FROM Products WHERE StockQuantity > 0";


                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    query += " AND (Name LIKE @search OR Category LIKE @search)";
                }


                if (cmbSort.SelectedItem.ToString() == "Price: Low to High")
                    query += " ORDER BY Price ASC";
                else if (cmbSort.SelectedItem.ToString() == "Price: High to Low")
                    query += " ORDER BY Price DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvShop.DataSource = dt;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAvailableProducts(txtSearch.Text.Trim());
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvShop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }


            int productId = Convert.ToInt32(dgvShop.SelectedRows[0].Cells["ProductID"].Value);
            string productName = dgvShop.SelectedRows[0].Cells["Name"].Value.ToString();
            int stockAvailable = Convert.ToInt32(dgvShop.SelectedRows[0].Cells["StockQuantity"].Value);
            int quantityObj = (int)numQuantity.Value;

            if (quantityObj <= 0)
            {
                MessageBox.Show("Please select a valid quantity.");
                return;
            }

            if (quantityObj > stockAvailable)
            {
                MessageBox.Show($"Only {stockAvailable} items left in stock!");
                return;
            }


            if (shoppingCart.ContainsKey(productId))
            {
                shoppingCart[productId] += quantityObj;
            }
            else
            {
                shoppingCart.Add(productId, quantityObj);
            }
            MessageBox.Show($"{quantityObj} x {productName} added to cart!");
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            if (shoppingCart.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }


            Checkout check = new Checkout(currentUserId, shoppingCart);
            check.Show();
        }

        private void btnLeaveReview_Click(object sender, EventArgs e)
        {

            if (dgvShop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to review.");
                return;
            }


            int pId = Convert.ToInt32(dgvShop.SelectedRows[0].Cells["ProductID"].Value);
            string pName = dgvShop.SelectedRows[0].Cells["Name"].Value.ToString();


            Review reviewForm = new Review(pId, pName, this.currentUserId);
            reviewForm.ShowDialog();

            LoadAvailableProducts("");
        }

        private void btnViewReviews_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvShop.SelectedRows.Count == 0) return;

            int pId = Convert.ToInt32(dgvShop.SelectedRows[0].Cells["ProductID"].Value);
            string pName = dgvShop.SelectedRows[0].Cells["Name"].Value.ToString();

            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT r.Rating, r.Comment, u.Username FROM Reviews r JOIN Users u ON r.CustomerID = u.UserID WHERE r.ProductID = @pid";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", pId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string allReviews = $"--- Reviews for {pName} ---\n\n";
                        while (reader.Read())
                        {
                            allReviews += $"★ {reader["Rating"]} - {reader["Username"]}\n";
                            allReviews += $"\"{reader["Comment"]}\"\n\n";
                        }

                        if (allReviews.Length < 40) allReviews += "No reviews yet.";

                        MessageBox.Show(allReviews, "Product Reviews", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void linkOrderHist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerOrders historyForm = new CustomerOrders(this.currentUserId);
            historyForm.ShowDialog();
        }

        private void linkProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserProfile userpr = new UserProfile(this.currentUserId);
            userpr.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
