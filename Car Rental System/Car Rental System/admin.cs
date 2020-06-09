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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        void Clear()
        {
            admtxt.Text = passwordtxt.Text = "";
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void cnictxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");

            string admin_ID = admtxt.Text;
            string password = passwordtxt.Text;

            con.Open();
            
            string query = "SELECT * FROM ADMIN_DETAILS WHERE ADMIN_ID=@adm_ID and PASSWORD2=@upass";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@adm_ID", admin_ID);
            cmd.Parameters.AddWithValue("@upass", password);

            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sd.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Clear();
                this.Hide();
                adminportal ss1 = new adminportal();
                ss1.Show();
            }
            else
            {
                MessageBox.Show("Incorrect ID or password.");
            }

            con.Close();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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
