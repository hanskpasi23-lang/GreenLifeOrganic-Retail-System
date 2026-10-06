namespace GreenLifeOrganic
{
    partial class CustomerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            txtSearch = new TextBox();
            cmbSort = new ComboBox();
            numQuantity = new NumericUpDown();
            panel1 = new Panel();
            btnLogout = new Button();
            lblWelcome = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            linkProfile = new LinkLabel();
            linkOrderHist = new LinkLabel();
            btnViewReviews = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            groupBox2 = new GroupBox();
            btnLeaveReview = new Button();
            btnViewCart = new Button();
            label3 = new Label();
            btnAddToCart = new Button();
            dgvShop = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShop).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(249, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(202, 31);
            txtSearch.TabIndex = 1;
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new Point(249, 92);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(202, 33);
            cmbSort.TabIndex = 2;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(119, 36);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(180, 31);
            numQuantity.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 76);
            panel1.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.Location = new Point(888, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(67, 45);
            btnLogout.TabIndex = 2;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.HighlightText;
            lblWelcome.Location = new Point(530, 17);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(160, 45);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome,";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(17, 17);
            label4.Name = "label4";
            label4.Size = new Size(337, 45);
            label4.TabIndex = 0;
            label4.Text = "Customer Dashboard";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.HighlightText;
            groupBox1.Controls.Add(linkProfile);
            groupBox1.Controls.Add(linkOrderHist);
            groupBox1.Controls.Add(btnViewReviews);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(cmbSort);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(954, 146);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // linkProfile
            // 
            linkProfile.AutoSize = true;
            linkProfile.Location = new Point(795, 19);
            linkProfile.Name = "linkProfile";
            linkProfile.Size = new Size(62, 25);
            linkProfile.TabIndex = 11;
            linkProfile.TabStop = true;
            linkProfile.Text = "Profile";
            linkProfile.LinkClicked += linkProfile_LinkClicked;
            // 
            // linkOrderHist
            // 
            linkOrderHist.AutoSize = true;
            linkOrderHist.Location = new Point(792, 60);
            linkOrderHist.Name = "linkOrderHist";
            linkOrderHist.Size = new Size(120, 25);
            linkOrderHist.TabIndex = 10;
            linkOrderHist.TabStop = true;
            linkOrderHist.Text = "Order History";
            linkOrderHist.LinkClicked += linkOrderHist_LinkClicked;
            // 
            // btnViewReviews
            // 
            btnViewReviews.AutoSize = true;
            btnViewReviews.Location = new Point(792, 101);
            btnViewReviews.Name = "btnViewReviews";
            btnViewReviews.Size = new Size(118, 25);
            btnViewReviews.TabIndex = 9;
            btnViewReviews.TabStop = true;
            btnViewReviews.Text = "Read Reviews";
            btnViewReviews.LinkClicked += btnViewReviews_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 95);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 8;
            label2.Text = "Sort By :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(219, 25);
            label1.TabIndex = 7;
            label1.Text = "Search Product/Category :";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.ForeColor = SystemColors.HighlightText;
            btnSearch.Location = new Point(468, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 35);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.HighlightText;
            groupBox2.Controls.Add(btnLeaveReview);
            groupBox2.Controls.Add(btnViewCart);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnAddToCart);
            groupBox2.Controls.Add(numQuantity);
            groupBox2.Location = new Point(12, 538);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(954, 95);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // btnLeaveReview
            // 
            btnLeaveReview.BackColor = Color.SteelBlue;
            btnLeaveReview.ForeColor = SystemColors.HighlightText;
            btnLeaveReview.Location = new Point(400, 29);
            btnLeaveReview.Name = "btnLeaveReview";
            btnLeaveReview.Size = new Size(191, 42);
            btnLeaveReview.TabIndex = 11;
            btnLeaveReview.Text = "Rate this Product";
            btnLeaveReview.UseVisualStyleBackColor = false;
            btnLeaveReview.Click += btnLeaveReview_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.BackColor = Color.SteelBlue;
            btnViewCart.ForeColor = SystemColors.HighlightText;
            btnViewCart.Location = new Point(792, 29);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(140, 42);
            btnViewCart.TabIndex = 10;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = false;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 38);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 9;
            label3.Text = "Quantity :";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.SteelBlue;
            btnAddToCart.ForeColor = SystemColors.HighlightText;
            btnAddToCart.Location = new Point(623, 29);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(140, 42);
            btnAddToCart.TabIndex = 4;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // dgvShop
            // 
            dgvShop.BackgroundColor = SystemColors.HighlightText;
            dgvShop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShop.Location = new Point(12, 244);
            dgvShop.Name = "dgvShop";
            dgvShop.RowHeadersWidth = 62;
            dgvShop.Size = new Size(954, 288);
            dgvShop.TabIndex = 7;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(981, 647);
            Controls.Add(dgvShop);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            Load += CustomerDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShop).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSearch;
        private ComboBox cmbSort;
        private NumericUpDown numQuantity;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSearch;
        private Button btnAddToCart;
        private DataGridView dgvShop;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label lblWelcome;
        private Button btnViewCart;
        private Button btnLeaveReview;
        private LinkLabel btnViewReviews;
        private LinkLabel linkOrderHist;
        private LinkLabel linkProfile;
        private Button btnLogout;
    }
}