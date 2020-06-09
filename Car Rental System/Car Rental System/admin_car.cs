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
    public partial class admin_car : Form
    {
        
        public admin_car()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");

        private void admin_car_Load(object sender, EventArgs e)
        {
            //searchData("");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminportal ss1 = new adminportal();
            ss1.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminportal ss1 = new adminportal();
            ss1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True;";
            SqlCommand cmd;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM BOOKING_DETAILS", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

               // dataGridView1.DataSource = dtbl;

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;

            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void emailtxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            searchData(search_txt.Text);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            //con.Open();
            searchData("");

        }
        public void searchData(string valueToFind)
        {

            string searchQuery = "SELECT * FROM BOOKING_DETAILS WHERE CONCAT(CATEGORY,MAKE,MODEL) LIKE '%" + valueToFind + "%'";
           
            SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

    }
}
