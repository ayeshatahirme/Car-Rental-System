namespace Car_Rental_System
{
    partial class book
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
            this.label6 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.drivertxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bookingidtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maketxt = new System.Windows.Forms.TextBox();
            this.modeltxt = new System.Windows.Forms.TextBox();
            this.categoryBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.availableBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 32);
            this.label6.TabIndex = 44;
            this.label6.Text = "Booking details";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // backbutton
            // 
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbutton.Location = new System.Drawing.Point(40, 384);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(88, 34);
            this.backbutton.TabIndex = 69;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(887, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 70;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addbtn
            // 
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbtn.Location = new System.Drawing.Point(687, 386);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(80, 32);
            this.addbtn.TabIndex = 73;
            this.addbtn.Text = "Proceed";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // drivertxt
            // 
            this.drivertxt.Location = new System.Drawing.Point(414, 320);
            this.drivertxt.Name = "drivertxt";
            this.drivertxt.Size = new System.Drawing.Size(154, 20);
            this.drivertxt.TabIndex = 88;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 87;
            this.label10.Text = "Want driver?";
            // 
            // bookingidtxt
            // 
            this.bookingidtxt.Location = new System.Drawing.Point(414, 97);
            this.bookingidtxt.Name = "bookingidtxt";
            this.bookingidtxt.Size = new System.Drawing.Size(154, 20);
            this.bookingidtxt.TabIndex = 84;
            this.bookingidtxt.TextChanged += new System.EventHandler(this.bookingidtxt_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(268, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 18);
            this.label11.TabIndex = 83;
            this.label11.Text = "Booking ID";
            // 
            // maketxt
            // 
            this.maketxt.Location = new System.Drawing.Point(414, 274);
            this.maketxt.Name = "maketxt";
            this.maketxt.Size = new System.Drawing.Size(154, 20);
            this.maketxt.TabIndex = 82;
            this.maketxt.TextChanged += new System.EventHandler(this.maketxt_TextChanged);
            // 
            // modeltxt
            // 
            this.modeltxt.Location = new System.Drawing.Point(414, 231);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(154, 20);
            this.modeltxt.TabIndex = 81;
            // 
            // categoryBox1
            // 
            this.categoryBox1.FormattingEnabled = true;
            this.categoryBox1.Location = new System.Drawing.Point(414, 142);
            this.categoryBox1.Name = "categoryBox1";
            this.categoryBox1.Size = new System.Drawing.Size(154, 21);
            this.categoryBox1.TabIndex = 78;
            this.categoryBox1.SelectedIndexChanged += new System.EventHandler(this.categoryBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 79;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 77;
            this.label3.Text = "Category";
            // 
            // availableBox
            // 
            this.availableBox.FormattingEnabled = true;
            this.availableBox.Location = new System.Drawing.Point(414, 187);
            this.availableBox.Name = "availableBox";
            this.availableBox.Size = new System.Drawing.Size(154, 21);
            this.availableBox.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 89;
            this.label8.Text = "Available";
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 457);
            this.Controls.Add(this.availableBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.drivertxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bookingidtxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maketxt);
            this.Controls.Add(this.modeltxt);
            this.Controls.Add(this.categoryBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "book";
            this.Text = "book";
            this.Load += new System.EventHandler(this.book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox drivertxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bookingidtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox maketxt;
        private System.Windows.Forms.TextBox modeltxt;
        private System.Windows.Forms.ComboBox categoryBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox availableBox;
        private System.Windows.Forms.Label label8;
    }
}