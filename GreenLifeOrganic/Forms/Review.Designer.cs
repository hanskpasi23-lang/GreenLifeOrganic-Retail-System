namespace GreenLifeOrganic
{
    partial class Review
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Review));
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnSubmitReview = new Button();
            txtComment = new RichTextBox();
            numRating = new NumericUpDown();
            lblProductName = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 45);
            label1.TabIndex = 0;
            label1.Text = "Cutomer Reviews";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.HighlightText;
            groupBox1.Controls.Add(btnSubmitReview);
            groupBox1.Controls.Add(txtComment);
            groupBox1.Controls.Add(numRating);
            groupBox1.Controls.Add(lblProductName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 400);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnSubmitReview
            // 
            btnSubmitReview.BackColor = Color.SteelBlue;
            btnSubmitReview.ForeColor = SystemColors.HighlightText;
            btnSubmitReview.Location = new Point(452, 341);
            btnSubmitReview.Name = "btnSubmitReview";
            btnSubmitReview.Size = new Size(184, 39);
            btnSubmitReview.TabIndex = 6;
            btnSubmitReview.Text = "Submit Review";
            btnSubmitReview.UseVisualStyleBackColor = false;
            btnSubmitReview.Click += btnSubmitReview_Click;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(197, 171);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(518, 144);
            txtComment.TabIndex = 5;
            txtComment.Text = "";
            // 
            // numRating
            // 
            numRating.Location = new Point(197, 105);
            numRating.Name = "numRating";
            numRating.Size = new Size(180, 31);
            numRating.TabIndex = 4;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(197, 51);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(0, 25);
            lblProductName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 171);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 2;
            label4.Text = "Comment :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 107);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 1;
            label3.Text = "Rating(1-5) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 51);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 0;
            label2.Text = "Product Name :";
            // 
            // Review
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 499);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Review";
            Text = "Review";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSubmitReview;
        private RichTextBox txtComment;
        private NumericUpDown numRating;
        private Label lblProductName;
    }
}