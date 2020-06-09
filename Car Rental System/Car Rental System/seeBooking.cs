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
    public partial class seeBooking : Form
    {
        public seeBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu ss = new menu();
            ss.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu ss = new menu();
            ss.Show();
        }

        private void seeBooking_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menu ss = new menu();
            ss.Show();
        }

        private void exitbutton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menu ss = new menu();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookingid_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");
            con.Open();

            if (bookingid_txt.Text != " ")
            {
                SqlCommand cmd = new SqlCommand("SELECT CATEGORY, MAKE, MODEL, DRIVER FROM BOOKING_DETAILS WHERE BOOKING_ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(bookingid_txt.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    category_txt.Text = da.GetValue(0).ToString();
                    make_txt.Text = da.GetValue(1).ToString();
                    model_txt.Text = da.GetValue(2).ToString();
                    driver_txt.Text = da.GetValue(3).ToString();
                }
                con.Close();
            }
        }
    }
}
