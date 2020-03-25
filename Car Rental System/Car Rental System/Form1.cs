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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss1 = new Form2();
            ss1.Show();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ss1 = new admin();
            ss1.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
