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
    public partial class adminportal : Form
    {
        
        public adminportal()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_car ss1 = new admin_car();
            ss1.Show();
            
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ss1 = new admin();
            ss1.Show();
        }

        private void adminportal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            add ss1 = new add();
            ss1.Show();
        }
    }
}
