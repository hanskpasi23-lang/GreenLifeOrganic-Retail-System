namespace GreenLifeOrganic
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new RichTextBox();
            txtFullName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(120, 45);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.HighlightText;
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(7, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 344);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(197, 255);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(503, 31);
            txtPassword.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(197, 184);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(503, 31);
            txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(197, 91);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(503, 72);
            txtAddress.TabIndex = 5;
            txtAddress.Text = "";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(197, 37);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(503, 31);
            txtFullName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 255);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 3;
            label5.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 184);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 2;
            label4.Text = "Phone Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 109);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 1;
            label3.Text = "Address :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 37);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 0;
            label2.Text = "Full Name :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.HighlightText;
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Location = new Point(11, 447);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(777, 116);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.ForeColor = SystemColors.HighlightText;
            btnUpdate.Location = new Point(593, 47);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(149, 44);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SteelBlue;
            btnClose.ForeColor = SystemColors.HighlightText;
            btnClose.Location = new Point(381, 47);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(149, 44);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 573);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserProfile";
            Text = "UserProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox txtAddress;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnClose;
    }
}