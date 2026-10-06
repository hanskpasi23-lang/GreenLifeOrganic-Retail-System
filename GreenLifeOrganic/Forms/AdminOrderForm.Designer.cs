namespace GreenLifeOrganic
{
    partial class AdminOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOrder));
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cmbStatus = new ComboBox();
            label4 = new Label();
            lblOrderId = new Label();
            label2 = new Label();
            dgvOrders = new DataGridView();
            groupBox2 = new GroupBox();
            btnUpdateStatus = new Button();
            btnViewDetails = new Button();
            linkExportCSV = new LinkLabel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 79);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(314, 45);
            label1.TabIndex = 0;
            label1.Text = "Order Management";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.HighlightText;
            groupBox1.Controls.Add(linkExportCSV);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblOrderId);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(7, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 102);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(467, 38);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(182, 33);
            cmbStatus.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 41);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 2;
            label4.Text = "Order Status :";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(118, 41);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(0, 25);
            lblOrderId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 41);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 0;
            label2.Text = "Order ID :";
            // 
            // dgvOrders
            // 
            dgvOrders.BackgroundColor = SystemColors.HighlightText;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(7, 205);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.Size = new Size(803, 304);
            dgvOrders.TabIndex = 2;
            dgvOrders.CellClick += dgvOrders_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.HighlightText;
            groupBox2.Controls.Add(btnUpdateStatus);
            groupBox2.Controls.Add(btnViewDetails);
            groupBox2.Location = new Point(7, 515);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(803, 78);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.SteelBlue;
            btnUpdateStatus.ForeColor = SystemColors.HighlightText;
            btnUpdateStatus.Location = new Point(609, 20);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(163, 42);
            btnUpdateStatus.TabIndex = 1;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.SteelBlue;
            btnViewDetails.ForeColor = SystemColors.HighlightText;
            btnViewDetails.Location = new Point(367, 20);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(163, 42);
            btnViewDetails.TabIndex = 0;
            btnViewDetails.Text = "View Order";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // linkExportCSV
            // 
            linkExportCSV.AutoSize = true;
            linkExportCSV.Location = new Point(665, 41);
            linkExportCSV.Name = "linkExportCSV";
            linkExportCSV.Size = new Size(122, 25);
            linkExportCSV.TabIndex = 4;
            linkExportCSV.TabStop = true;
            linkExportCSV.Text = "Export to CSV";
            linkExportCSV.LinkClicked += linkExportCSV_LinkClicked;
            // 
            // AdminOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(822, 605);
            Controls.Add(groupBox2);
            Controls.Add(dgvOrders);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminOrder";
            Text = "AdminOrder";
            Load += AdminOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cmbStatus;
        private Label label4;
        private Label lblOrderId;
        private Label label2;
        private DataGridView dgvOrders;
        private GroupBox groupBox2;
        private Button btnUpdateStatus;
        private Button btnViewDetails;
        private LinkLabel linkExportCSV;
    }
}