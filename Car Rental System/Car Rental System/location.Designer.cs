﻿namespace Car_Rental_System
{
    partial class location
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
            this.dropoff = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pickup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.bookbtn = new System.Windows.Forms.Button();
            this.membershiptxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropoff
            // 
            this.dropoff.Location = new System.Drawing.Point(417, 205);
            this.dropoff.Multiline = true;
            this.dropoff.Name = "dropoff";
            this.dropoff.Size = new System.Drawing.Size(154, 32);
            this.dropoff.TabIndex = 80;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(231, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 18);
            this.label14.TabIndex = 79;
            this.label14.Text = "Dropoff Location";
            // 
            // pickup
            // 
            this.pickup.Location = new System.Drawing.Point(417, 149);
            this.pickup.Multiline = true;
            this.pickup.Name = "pickup";
            this.pickup.Size = new System.Drawing.Size(154, 34);
            this.pickup.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "Pickup Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 83;
            this.label1.Text = "Car Rental System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 84;
            this.label2.Text = "Booking details";
            // 
            // backbutton
            // 
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbutton.Location = new System.Drawing.Point(54, 380);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(88, 34);
            this.backbutton.TabIndex = 85;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // bookbtn
            // 
            this.bookbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookbtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bookbtn.Location = new System.Drawing.Point(663, 380);
            this.bookbtn.Name = "bookbtn";
            this.bookbtn.Size = new System.Drawing.Size(88, 34);
            this.bookbtn.TabIndex = 86;
            this.bookbtn.Text = "Book me!";
            this.bookbtn.UseVisualStyleBackColor = true;
            this.bookbtn.Click += new System.EventHandler(this.bookbtn_Click);
            // 
            // membershiptxt
            // 
            this.membershiptxt.Location = new System.Drawing.Point(417, 306);
            this.membershiptxt.Name = "membershiptxt";
            this.membershiptxt.Size = new System.Drawing.Size(154, 20);
            this.membershiptxt.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 93;
            this.label3.Text = "Membership ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 97;
            this.label6.Text = "Number of days";
            // 
            // location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.membershiptxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookbtn);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropoff);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pickup);
            this.Controls.Add(this.label4);
            this.Name = "location";
            this.Text = "location";
            this.Load += new System.EventHandler(this.location_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dropoff;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pickup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button bookbtn;
        private System.Windows.Forms.TextBox membershiptxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}