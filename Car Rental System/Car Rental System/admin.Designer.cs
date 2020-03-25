namespace Car_Rental_System
{
    partial class admin
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.admtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "You\'re better off driving our way.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "Car Rental System";
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitbutton.Location = new System.Drawing.Point(66, 399);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 27);
            this.exitbutton.TabIndex = 22;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Login Form";
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginbutton.Location = new System.Drawing.Point(662, 399);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 26);
            this.loginbutton.TabIndex = 28;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Password";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(334, 249);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(193, 20);
            this.passwordtxt.TabIndex = 26;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // admtxt
            // 
            this.admtxt.Location = new System.Drawing.Point(334, 193);
            this.admtxt.Name = "admtxt";
            this.admtxt.Size = new System.Drawing.Size(193, 20);
            this.admtxt.TabIndex = 25;
            this.admtxt.TextChanged += new System.EventHandler(this.cnictxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Admin ID";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(426, 285);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.admtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox admtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}