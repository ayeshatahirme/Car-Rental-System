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
    public partial class location : Form
    {
        public location()
        {
            InitializeComponent();
        }

        void clearData()
        {
           // zipcode.Text = "";
            pickup.Text = "";
            dropoff.Text = "";
            textBox1.Text = "";
            membershiptxt.Text = "";
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            bookingDetails ss = new bookingDetails();
            ss.Show();
        }

        private void location_Load(object sender, EventArgs e)
        {/*
            string zipcode2 = zipcode.Text;
            string pickupLoc = pickup.Text;
            string dropoffLoc = dropoff.Text;
            string dateFrom = date.Text;
            string dateReturn = returndate.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystem;Integrated Security=True");
            con.Open();

            string query = "insert into LOCATION_DETAILS(ZIPCODE, FROM_DATE, RET_DATE, PICKUP_LOCATION, DROP_LOCATION) " +
                "values(@zipcode1, @fromdate1,  @returnfrom1, @pickuploc1, @dropoffloc1)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@pickuploc1", zipcode2);
            cmd.Parameters.AddWithValue("@fromdate", dateFrom);
            cmd.Parameters.AddWithValue("@returnfrom1", dateReturn);
            cmd.Parameters.AddWithValue("@pickuploc1", pickupLoc);
            cmd.Parameters.AddWithValue("@dropoffloc1", dropoffLoc);
            */
        }

        private void bookbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");
            con.Open();

            string query = "INSERT INTO LOCATION_DETAILS(NUMBER_OF_DAYS, PICKUP_LOCATION, DROPOFF_LOCATION)" +
                "VALUES(@NUMBER_OF_DAYS, @pickuploc, @dropoffloc)";

            SqlCommand cmd = new SqlCommand(query, con);

           // cmd.Parameters.AddWithValue("@zipcode", zipcode.Text);
            cmd.Parameters.AddWithValue("@NUMBER_OF_DAYS", textBox1.Text);
            cmd.Parameters.AddWithValue("@pickuploc", pickup.Text);
            cmd.Parameters.AddWithValue("@dropoffloc", dropoff.Text);


            cmd.ExecuteNonQuery();
            MessageBox.Show("Record added!");

            clearData();
       //   populatedata();
            con.Close();


            /*string query = "insert into BOOKING_DETAILS(BOOKING_ID, CATEGORY, MODEL, MAKE, AVAILABLE, DRIVER) " +
                "values(@booking1, @category1, @model1, @make1, @available1, @driver1)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@booking1", bookingidtxt.Text);
            cmd.Parameters.AddWithValue("@category1", categoryBox1.Text);
            cmd.Parameters.AddWithValue("@model1", modeltxt.Text);
            cmd.Parameters.AddWithValue("@make1", maketxt.Text);
            cmd.Parameters.AddWithValue("@available1", availableBox.Text);
            cmd.Parameters.AddWithValue("@driver1", drivertxt.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record added!");

            clearData();
            populatedata();
            con.Close();*/












            this.Hide();
            menu ss = new menu();
            ss.Show();
            MessageBox.Show("Your car is booked. Enjoy!");
        }
    }
}
