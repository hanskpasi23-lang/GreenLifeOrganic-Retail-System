namespace GreenLifeOrganic
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            panel1 = new Panel();
            label1 = new Label();
            dgvCart = new DataGridView();
            panel2 = new Panel();
            lblTotal = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            btnRemoveItem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(160, 45);
            label1.TabIndex = 0;
            label1.Text = "Checkout";
            // 
            // dgvCart
            // 
            dgvCart.BackgroundColor = SystemColors.HighlightText;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(12, 88);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 62;
            dgvCart.Size = new Size(1111, 344);
            dgvCart.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Controls.Add(btnRemoveItem);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnConfirm);
            panel2.Location = new Point(12, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 119);
            panel2.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(49, 44);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 38);
            lblTotal.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SteelBlue;
            btnCancel.ForeColor = SystemColors.HighlightText;
            btnCancel.Location = new Point(936, 44);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 48);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.SteelBlue;
            btnConfirm.ForeColor = SystemColors.HighlightText;
            btnConfirm.Location = new Point(757, 44);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(143, 48);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.SteelBlue;
            btnRemoveItem.ForeColor = SystemColors.HighlightText;
            btnRemoveItem.Location = new Point(572, 43);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(143, 48);
            btnRemoveItem.TabIndex = 4;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1137, 569);
            Controls.Add(panel2);
            Controls.Add(dgvCart);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Checkout";
            Text = "Checkout";
            Load += Checkout_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvCart;
        private Panel panel2;
        private Button btnCancel;
        private Button btnConfirm;
        private Label label1;
        private Label lblTotal;
        private Button btnRemoveItem;
    }
}