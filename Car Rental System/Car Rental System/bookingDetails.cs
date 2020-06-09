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
    public partial class bookingDetails : Form
    {
        public bookingDetails()
        {
            InitializeComponent();
        }

        void save_data_into_datbase()
        {
            if (checkname())
            {
                MessageBox.Show("Data is already saved.");
                populatedata();
            }
            else
            {
                if (bookingidtxt.Text == "")
                {
                    MessageBox.Show("Invalid save credentials.");
                }
                else
                {


                }
            }
        }
        private Boolean checkname()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
            Boolean nameavailable = false;
            string myquery = "Select *from BOOKING_DETAILS where BOOKING_ID='" + bookingidtxt.Text + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                nameavailable = true;
            }
            con.Close();
            return nameavailable;
        }


        void clearData()
        {
            bookingidtxt.Text = "";
            categoryBox1.Text = "";
            modeltxt.Text = "";
            maketxt.Text = "";
            drivertxt.Text = "";
        }


        private void populatedata()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from BOOKING_DETAILS", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            /*   dataGridView1.Rows.Clear();
               for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
               {

                   string booking_id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                   string category = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                   string model = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                   string make = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                   string avaiable = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                   string driver = ds.Tables[0].Rows[i].ItemArray[5].ToString();

                   DataGridViewRow show = new DataGridViewRow();
                   show.CreateCells(dataGridView1);
                   show.Cells[0].Value = booking_id;
                   show.Cells[1].Value = category;
                   show.Cells[2].Value = model;
                   show.Cells[3].Value = make;
                   show.Cells[4].Value = avaiable;
                   show.Cells[5].Value = driver;

                   dataGridView1.Rows.Add(show);
               }
               con.Close();*/
        }

        private void bookingDetails_Load(object sender, EventArgs e)
        {

        }

        private void categoryBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryBox1.Text == "COMPACT")
            {
                MessageBox.Show("Amount per day = 3,000 and late fee per day = 300");

            }
            if (categoryBox1.Text == "ECONOMY")
            {
                MessageBox.Show("Amount per day = 5,000 and late fee per day = 500");
            }
            if (categoryBox1.Text == "FULL SIZE")
            {
                MessageBox.Show("Amount per day = 4,000 and late fee per day = 400");
            }
            if (categoryBox1.Text == "LUXURY CAR")
            {
                MessageBox.Show("Amount per day = 7,000 and late fee per day = 700");
            }
            if (categoryBox1.Text == "MID SIZE")
            {
                MessageBox.Show("Amount per day = 2,000 and late fee per day = 200");
            }
            if (categoryBox1.Text == "STANDARD")
            {
                MessageBox.Show("Amount per day = 2,500 and late fee per day = 250");
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu ss = new menu();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save_data_into_datbase();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");
            con.Open();

            string query = "insert into BOOKING_DETAILS(BOOKING_ID, CATEGORY, MODEL, MAKE, DRIVER) " +
                "values(@booking1, @category1, @model1, @make1, @driver1)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@booking1", bookingidtxt.Text);
            cmd.Parameters.AddWithValue("@category1", categoryBox1.Text);
            cmd.Parameters.AddWithValue("@model1", modeltxt.Text);
            cmd.Parameters.AddWithValue("@make1", maketxt.Text);
            cmd.Parameters.AddWithValue("@driver1", drivertxt.Text);

            cmd.ExecuteNonQuery();
            // MessageBox.Show("Record added!");



            clearData();
            //populatedata();
            con.Close();

            this.Hide();
            location ss = new location();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");
            // con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CAR_CATEGORY ORDER BY CATEGORY_NAME", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 1; i < dt.Rows.Count; i++)
            {
                categoryBox1.Items.Add(dt.Rows[i]["CATEGORY_NAME"]);
            }

            if (categoryBox1.Text == "COMPACT")
            {
                MessageBox.Show("Amount per day = 3,000 and late fee per day = 300");
            }
            if (categoryBox1.Text == "ECONOMY")
            {
                MessageBox.Show("Amount per day = 5,000 and late fee per day = 500");
            }
            if (categoryBox1.Text == "FULL SIZE")
            {
                MessageBox.Show("Amount per day = 4,000 and late fee per day = 400");
            }
            if (categoryBox1.Text == "LUXURY CAR")
            {
                MessageBox.Show("Amount per day = 7,000 and late fee per day = 700");
            }
            if (categoryBox1.Text == "MID SIZE")
            {
                MessageBox.Show("Amount per day = 2,000 and late fee per day = 200");
            }
            if (categoryBox1.Text == "STANDARD")
            {
                MessageBox.Show("Amount per day = 2,500 and late fee per day = 250");
            }
            if (categoryBox1.Text == "GLI")
            {
                MessageBox.Show("Amount per day = 2,500 and late fee per day = 550");
            }
            if (categoryBox1.Text == "MINI")
            {
                MessageBox.Show("Amount per day = 1,500 and late fee per day = 150");
            }
            if (categoryBox1.Text == "SSD")
            {
                MessageBox.Show("Amount per day = 1,000 and late fee per day = 1,500");
            }
            if (categoryBox1.Text == "MAX HONDA")
            {
                MessageBox.Show("Amount per day = 9,000 and late fee per day = 900");
            }
        }
    }
}





    
  