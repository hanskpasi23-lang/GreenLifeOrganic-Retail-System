namespace GreenLifeOrganic
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            txtSupplier = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvProducts = new DataGridView();
            lblProductID = new Label();
            btnClear = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            label6 = new Label();
            groupBox1 = new GroupBox();
            linkStockCSV = new LinkLabel();
            txtDiscount = new TextBox();
            label7 = new Label();
            linkMngCus = new LinkLabel();
            linkMngOrders = new LinkLabel();
            linkSalesRep = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 27);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 1;
            label2.Text = "Category :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(460, 27);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(820, 27);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 3;
            label4.Text = "Stock Quantity :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1049, 27);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 4;
            label5.Text = "Supplier :";
            // 
            // txtName
            // 
            txtName.Location = new Point(25, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(160, 31);
            txtName.TabIndex = 5;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(216, 58);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(165, 31);
            txtCategory.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(412, 58);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(166, 31);
            txtPrice.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(807, 58);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(162, 31);
            txtStock.TabIndex = 8;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(1007, 58);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(168, 31);
            txtSupplier.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.ForeColor = SystemColors.HighlightText;
            btnAdd.Location = new Point(393, 135);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 42);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.ForeColor = SystemColors.HighlightText;
            btnUpdate.Location = new Point(535, 135);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 42);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.ForeColor = SystemColors.HighlightText;
            btnDelete.Location = new Point(673, 135);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 42);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = SystemColors.HighlightText;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 310);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.Size = new Size(1390, 315);
            dgvProducts.TabIndex = 13;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(269, 628);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(0, 25);
            lblProductID.TabIndex = 14;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.ForeColor = SystemColors.HighlightText;
            btnClear.Location = new Point(815, 135);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 42);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1412, 78);
            panel1.TabIndex = 16;
            // 
            // btnLogout
            // 
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.Location = new Point(1319, 19);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(67, 45);
            btnLogout.TabIndex = 1;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(23, 19);
            label6.Name = "label6";
            label6.Size = new Size(293, 45);
            label6.TabIndex = 0;
            label6.Text = "Admin Dashboard";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.HighlightText;
            groupBox1.Controls.Add(linkStockCSV);
            groupBox1.Controls.Add(txtDiscount);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(linkMngCus);
            groupBox1.Controls.Add(linkMngOrders);
            groupBox1.Controls.Add(linkSalesRep);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtSupplier);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1390, 209);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // linkStockCSV
            // 
            linkStockCSV.AutoSize = true;
            linkStockCSV.Location = new Point(1217, 169);
            linkStockCSV.Name = "linkStockCSV";
            linkStockCSV.Size = new Size(92, 25);
            linkStockCSV.TabIndex = 21;
            linkStockCSV.TabStop = true;
            linkStockCSV.Text = "Stock CSV";
            linkStockCSV.LinkClicked += linkStockCSV_LinkClicked;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(615, 58);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(156, 31);
            txtDiscount.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(639, 27);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 19;
            label7.Text = "Discount :";
            // 
            // linkMngCus
            // 
            linkMngCus.AutoSize = true;
            linkMngCus.Location = new Point(1217, 27);
            linkMngCus.Name = "linkMngCus";
            linkMngCus.Size = new Size(158, 25);
            linkMngCus.TabIndex = 18;
            linkMngCus.TabStop = true;
            linkMngCus.Text = "Manage Customer";
            linkMngCus.LinkClicked += linkMngCus_LinkClicked;
            // 
            // linkMngOrders
            // 
            linkMngOrders.AutoSize = true;
            linkMngOrders.Location = new Point(1217, 77);
            linkMngOrders.Name = "linkMngOrders";
            linkMngOrders.Size = new Size(135, 25);
            linkMngOrders.TabIndex = 17;
            linkMngOrders.TabStop = true;
            linkMngOrders.Text = "Manage Orders";
            linkMngOrders.LinkClicked += linkMngOrders_LinkClicked;
            // 
            // linkSalesRep
            // 
            linkSalesRep.AutoSize = true;
            linkSalesRep.Location = new Point(1217, 124);
            linkSalesRep.Name = "linkSalesRep";
            linkSalesRep.Size = new Size(120, 25);
            linkSalesRep.TabIndex = 16;
            linkSalesRep.TabStop = true;
            linkSalesRep.Text = "Total Revenue";
            linkSalesRep.LinkClicked += linkSalesRep_LinkClicked;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1414, 635);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(lblProductID);
            Controls.Add(dgvProducts);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private TextBox txtStock;
        private TextBox txtSupplier;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvProducts;
        private Label lblProductID;
        private Button btnClear;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label6;
        private LinkLabel linkSalesRep;
        private LinkLabel linkMngOrders;
        private LinkLabel linkMngCus;
        private TextBox txtDiscount;
        private Label label7;
        private Button btnLogout;
        private LinkLabel linkStockCSV;
    }
}