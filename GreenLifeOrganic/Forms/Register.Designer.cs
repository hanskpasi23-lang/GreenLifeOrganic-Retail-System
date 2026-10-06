namespace GreenLifeOrganic
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtRegPhone = new TextBox();
            txtRegAddress = new RichTextBox();
            txtEmail = new TextBox();
            txtRegName = new TextBox();
            txtRegPassword = new TextBox();
            txtRegUsername = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnSubmitRegister = new Button();
            btnBackToLogin = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 74);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(26, 10);
            label1.Name = "label1";
            label1.Size = new Size(355, 45);
            label1.TabIndex = 1;
            label1.Text = "New User Registration";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.HighlightText;
            groupBox1.Controls.Add(txtRegPhone);
            groupBox1.Controls.Add(txtRegAddress);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtRegName);
            groupBox1.Controls.Add(txtRegPassword);
            groupBox1.Controls.Add(txtRegUsername);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 421);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtRegPhone
            // 
            txtRegPhone.Location = new Point(196, 266);
            txtRegPhone.Name = "txtRegPhone";
            txtRegPhone.Size = new Size(467, 31);
            txtRegPhone.TabIndex = 11;
            // 
            // txtRegAddress
            // 
            txtRegAddress.Location = new Point(196, 325);
            txtRegAddress.Name = "txtRegAddress";
            txtRegAddress.Size = new Size(467, 69);
            txtRegAddress.TabIndex = 10;
            txtRegAddress.Text = "";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(196, 205);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(467, 31);
            txtEmail.TabIndex = 9;
            // 
            // txtRegName
            // 
            txtRegName.Location = new Point(196, 149);
            txtRegName.Name = "txtRegName";
            txtRegName.Size = new Size(467, 31);
            txtRegName.TabIndex = 8;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(196, 95);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.PasswordChar = '*';
            txtRegPassword.Size = new Size(467, 31);
            txtRegPassword.TabIndex = 7;
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(196, 42);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(467, 31);
            txtRegUsername.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 214);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 5;
            label7.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 341);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 4;
            label6.Text = "Delivery Address :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 269);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 3;
            label5.Text = "Phone Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 158);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 2;
            label4.Text = "Full Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 101);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 1;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 45);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 0;
            label2.Text = "Username :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Controls.Add(btnSubmitRegister);
            panel2.Controls.Add(btnBackToLogin);
            panel2.Location = new Point(12, 517);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 90);
            panel2.TabIndex = 2;
            // 
            // btnSubmitRegister
            // 
            btnSubmitRegister.BackColor = Color.SteelBlue;
            btnSubmitRegister.ForeColor = SystemColors.HighlightText;
            btnSubmitRegister.Location = new Point(595, 30);
            btnSubmitRegister.Name = "btnSubmitRegister";
            btnSubmitRegister.Size = new Size(147, 42);
            btnSubmitRegister.TabIndex = 1;
            btnSubmitRegister.Text = "Register";
            btnSubmitRegister.UseVisualStyleBackColor = false;
            btnSubmitRegister.Click += btnSubmitRegister_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.SteelBlue;
            btnBackToLogin.ForeColor = SystemColors.HighlightText;
            btnBackToLogin.Location = new Point(402, 30);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(158, 42);
            btnBackToLogin.TabIndex = 0;
            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 619);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtRegName;
        private TextBox txtRegPassword;
        private TextBox txtRegUsername;
        private Label label7;
        private TextBox txtRegPhone;
        private RichTextBox txtRegAddress;
        private Panel panel2;
        private Button btnSubmitRegister;
        private Button btnBackToLogin;
    }
}