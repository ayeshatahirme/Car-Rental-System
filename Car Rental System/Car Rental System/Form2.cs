using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Car_Rental_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup ss = new signup();
            ss.Show();
        }

        void Clear()
        {
            cnictxt.Text = passwordtxt.Text = "";
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");

            string cnic = cnictxt.Text;
            string password = passwordtxt.Text;

            con.Open();
            string query = "SELECT * FROM CUSTOMER_DETAILS WHERE CNIC=@ucnic and PASSWORD1=@upass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ucnic", cnic);
            cmd.Parameters.AddWithValue("@upass", password);

            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sd.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Clear();
                this.Hide();
                menu ss1 = new menu();
                ss1.Show();
            }
            else
            {
                MessageBox.Show("Incorrect CNIC or password.");
            }

            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            signup s1 = new signup();
            s1.Show();
        }

        private void loginbutton_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");

            string cnic = cnictxt.Text;
            string password = passwordtxt.Text;

            con.Open();
            string query = "SELECT * FROM CUSTOMER_DETAILS WHERE CNIC=@ucnic and PASSWORD1=@upass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ucnic", cnic);
            cmd.Parameters.AddWithValue("@upass", password);

            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sd.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Clear();
                this.Hide();
                menu ss1 = new menu();
                ss1.Show();
            }
            else
            {
                MessageBox.Show("Incorrect CNIC or password.");
            }

            con.Close();
        }

        private void exitbutton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cnictxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                passwordtxt.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtxt.UseSystemPasswordChar = true;
            }
        }
    }
}
