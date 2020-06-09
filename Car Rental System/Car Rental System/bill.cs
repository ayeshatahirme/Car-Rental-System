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
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void bill_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu ss = new menu();
            ss.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void button3_Click_1(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystem;Integrated Security=True");

            string bookingId = textBox4.Text;
           
            con.Open();
            string query = "SELECT * FROM BOOKING_DETAILS WHERE BOOKING_ID=@ubookingId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ubookingId", bookingId);

           // SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sd.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                
            }
            else
            {
                MessageBox.Show("Incorrect ID entered!");
            }

            con.Close();*/
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");
            con.Open();
            if(textBox4.Text!="")
            {
                SqlCommand cmd = new SqlCommand("SELECT BOOKINGFK4, TOTAL_AMOUNT, TOTAL_FEE, TAX_AMOUNT, DISCOUNT_AMOUNT, NUMBER_OF_DAYS, DRIVER_FEE WHERE BOOKING_ID=@BOOKING_ID", con);
                cmd.Parameters.AddWithValue("@BOOKING_ID", int.Parse(textBox4.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while(da.Read())
                {
                    textBox5.Text = da.GetValue(0).ToString();
                    textBox8.Text = da.GetValue(5).ToString();
                    textBox2.Text = da.GetValue(2).ToString();
                    textBox6.Text = da.GetValue(6).ToString();
                    textBox1.Text = da.GetValue(3).ToString();
                    textBox7.Text = da.GetValue(4).ToString();
                    textBox3.Text = da.GetValue(1).ToString();

                }
                con.Close();
            }
        }
    }
}
