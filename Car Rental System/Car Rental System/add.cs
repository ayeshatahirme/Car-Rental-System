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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminportal ss1 = new adminportal();
            ss1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string costPerDay = costtxt.Text;
            string lateFeePerDay = latetxt.Text;
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");
            con.Open();

            string query = "insert into CAR_CATEGORY(CATEGORY_NAME, COST_PER_DAY, LATE_FEE_PER_DAY) " +
                "values(@name1, @cost1, @late1)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name1", name);
            cmd.Parameters.AddWithValue("@cost1", costPerDay);
            cmd.Parameters.AddWithValue("@late1", lateFeePerDay);
            
            cmd.ExecuteNonQuery();
            con.Close();
            displatData();
            MessageBox.Show("Vehicle added!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displatData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM CAR_CATEGORY WHERE CATEGORY_NAME='" + nametxt.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            displatData();

            MessageBox.Show("Record deleted successfully!");
        }

        public void displatData()
        {
            string connectionString = @"Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True;";
            SqlCommand cmd;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM CAR_CATEGORY", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // dataGridView1.DataSource = dtbl;

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;

            }
        }

        private void add_Load(object sender, EventArgs e)
        {

        }
    }
}
