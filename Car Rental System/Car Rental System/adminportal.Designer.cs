namespace Car_Rental_System
{
    partial class adminportal
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
            this.loginbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 38;
            this.label6.Text = "Login Form";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginbutton.Location = new System.Drawing.Point(661, 402);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 26);
            this.loginbutton.TabIndex = 37;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitbutton.Location = new System.Drawing.Point(65, 402);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 27);
            this.exitbutton.TabIndex = 32;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "You\'re better off driving our way.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 37);
            this.label4.TabIndex = 30;
            this.label4.Text = "Car Rental System";
            // 
            // adminportal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "adminportal";
            this.Text = "adminportal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}