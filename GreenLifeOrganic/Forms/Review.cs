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
    public partial class Review : Form
    {
        private int productId;
        private int customerId;

        public Review(int pId, string pName, int cId)
        {
            InitializeComponent();
            this.productId = pId;
            this.customerId = cId;
            lblProductName.Text = "Reviewing: " + pName;
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("Please write a comment.");
                return;
            }

            int rating = (int)numRating.Value;

            using (SqlConnection conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    
                    string insertQuery = "INSERT INTO Reviews (ProductID, CustomerID, Rating, Comment) VALUES (@pid, @cid, @rating, @comment)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@pid", productId);
                        cmd.Parameters.AddWithValue("@cid", customerId);
                        cmd.Parameters.AddWithValue("@rating", rating);
                        cmd.Parameters.AddWithValue("@comment", txtComment.Text);
                        cmd.ExecuteNonQuery();
                    }

                    
                    string updateAvgQuery = @"
                        UPDATE Products 
                        SET Rating = (SELECT AVG(CAST(Rating AS DECIMAL(2,1))) FROM Reviews WHERE ProductID = @pid)
                        WHERE ProductID = @pid";

                    using (SqlCommand cmd = new SqlCommand(updateAvgQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@pid", productId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Thank you for your review!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error submitting review: " + ex.Message);
                }
            }
        }
    }
}
