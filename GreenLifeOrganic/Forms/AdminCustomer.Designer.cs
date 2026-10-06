namespace GreenLifeOrganic
{
    partial class AdminCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCustomer));
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            lblSelectedID = new Label();
            txtSearchCust = new TextBox();
            label2 = new Label();
            btnUpdateCust = new Button();
            dgvCustomers = new DataGridView();
            groupBox2 = new GroupBox();
            btnClearSelection = new Button();
            txtCustAddress = new RichTextBox();
            txtCustPhone = new TextBox();
            txtCustEmail = new TextBox();
            txtCustName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(294, 45);
            label1.TabIndex = 0;
            label1.Text = "Manage Customer";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.HighlightText;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblSelectedID);
            groupBox1.Controls.Add(txtSearchCust);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(840, 85);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 38);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 3;
            label3.Text = "Selected ID :";
            // 
            // lblSelectedID
            // 
            lblSelectedID.AutoSize = true;
            lblSelectedID.Location = new Point(616, 37);
            lblSelectedID.Name = "lblSelectedID";
            lblSelectedID.Size = new Size(0, 25);
            lblSelectedID.TabIndex = 2;
            // 
            // txtSearchCust
            // 
            txtSearchCust.Location = new Point(204, 34);
            txtSearchCust.Name = "txtSearchCust";
            txtSearchCust.Size = new Size(216, 31);
            txtSearchCust.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 34);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 0;
            label2.Text = "Search Customer :";
            // 
            // btnUpdateCust
            // 
            btnUpdateCust.BackColor = Color.SteelBlue;
            btnUpdateCust.ForeColor = SystemColors.HighlightText;
            btnUpdateCust.Location = new Point(674, 151);
            btnUpdateCust.Name = "btnUpdateCust";
            btnUpdateCust.Size = new Size(107, 35);
            btnUpdateCust.TabIndex = 2;
            btnUpdateCust.Text = "Update";
            btnUpdateCust.UseVisualStyleBackColor = false;
            btnUpdateCust.Click += btnUpdateCust_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = SystemColors.HighlightText;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(12, 184);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 62;
            dgvCustomers.Size = new Size(840, 281);
            dgvCustomers.TabIndex = 2;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.HighlightText;
            groupBox2.Controls.Add(btnClearSelection);
            groupBox2.Controls.Add(txtCustAddress);
            groupBox2.Controls.Add(txtCustPhone);
            groupBox2.Controls.Add(txtCustEmail);
            groupBox2.Controls.Add(txtCustName);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnUpdateCust);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 471);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(840, 202);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnClearSelection
            // 
            btnClearSelection.BackColor = Color.SteelBlue;
            btnClearSelection.ForeColor = SystemColors.HighlightText;
            btnClearSelection.Location = new Point(497, 151);
            btnClearSelection.Name = "btnClearSelection";
            btnClearSelection.Size = new Size(107, 35);
            btnClearSelection.TabIndex = 10;
            btnClearSelection.Text = "Clear";
            btnClearSelection.UseVisualStyleBackColor = false;
            btnClearSelection.Click += btnClearSelection_Click;
            // 
            // txtCustAddress
            // 
            txtCustAddress.Location = new Point(27, 133);
            txtCustAddress.Name = "txtCustAddress";
            txtCustAddress.Size = new Size(403, 53);
            txtCustAddress.TabIndex = 9;
            txtCustAddress.Text = "";
            // 
            // txtCustPhone
            // 
            txtCustPhone.Location = new Point(504, 61);
            txtCustPhone.Name = "txtCustPhone";
            txtCustPhone.Size = new Size(223, 31);
            txtCustPhone.TabIndex = 8;
            // 
            // txtCustEmail
            // 
            txtCustEmail.Location = new Point(251, 61);
            txtCustEmail.Name = "txtCustEmail";
            txtCustEmail.Size = new Size(207, 31);
            txtCustEmail.TabIndex = 7;
            // 
            // txtCustName
            // 
            txtCustName.Location = new Point(27, 61);
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(185, 31);
            txtCustName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 105);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 3;
            label7.Text = "Address :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(524, 27);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 5;
            label6.Text = "Phone Number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 27);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 4;
            label5.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 27);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 3;
            label4.Text = "Full Name :";
            // 
            // AdminCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(864, 685);
            Controls.Add(groupBox2);
            Controls.Add(dgvCustomers);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminCustomer";
            Text = "AdminCustomer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnUpdateCust;
        private TextBox txtSearchCust;
        private Label label2;
        private DataGridView dgvCustomers;
        private Label lblSelectedID;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private RichTextBox txtCustAddress;
        private TextBox txtCustPhone;
        private TextBox txtCustEmail;
        private TextBox txtCustName;
        private Label label7;
        private Button btnClearSelection;
        private Label label3;
    }
}