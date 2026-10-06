namespace GreenLifeOrganic
{
    partial class CustomerOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrders));
            panel1 = new Panel();
            label1 = new Label();
            dgvMyOrders = new DataGridView();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            lblInstruction = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyOrders).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(29, 19);
            label1.Name = "label1";
            label1.Size = new Size(227, 45);
            label1.TabIndex = 0;
            label1.Text = "Order History";
            // 
            // dgvMyOrders
            // 
            dgvMyOrders.BackgroundColor = SystemColors.HighlightText;
            dgvMyOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyOrders.Location = new Point(5, 184);
            dgvMyOrders.Name = "dgvMyOrders";
            dgvMyOrders.RowHeadersWidth = 62;
            dgvMyOrders.Size = new Size(664, 306);
            dgvMyOrders.TabIndex = 1;
            dgvMyOrders.CellClick += dgvMyOrders_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.HighlightText;
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(lblInstruction);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(5, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(664, 88);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SteelBlue;
            btnClose.ForeColor = SystemColors.HighlightText;
            btnClose.Location = new Point(497, 30);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 39);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstruction.ForeColor = Color.Firebrick;
            lblInstruction.Location = new Point(23, 38);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(258, 25);
            lblInstruction.TabIndex = 0;
            lblInstruction.Text = "Click on anorder to see items";
            // 
            // CustomerOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(679, 502);
            Controls.Add(groupBox1);
            Controls.Add(dgvMyOrders);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerOrders";
            Text = "CustomerOrders";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyOrders).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgvMyOrders;
        private GroupBox groupBox1;
        private Label lblInstruction;
        private Button btnClose;
    }
}