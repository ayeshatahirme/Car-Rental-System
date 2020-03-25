namespace Car_Rental_System
{
    partial class loginform
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.signupbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Car Rental System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "You\'re better off driving our way.";
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitbutton.Location = new System.Drawing.Point(77, 373);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 27);
            this.exitbutton.TabIndex = 11;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Login As";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(313, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 57);
            this.button2.TabIndex = 27;
            this.button2.Text = "Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // signupbutton
            // 
            this.signupbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbutton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signupbutton.Location = new System.Drawing.Point(313, 179);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(141, 58);
            this.signupbutton.TabIndex = 25;
            this.signupbutton.Text = "Admin";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "loginform";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button signupbutton;
    }
}

