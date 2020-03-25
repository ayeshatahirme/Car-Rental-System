using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform ss = new loginform();
            ss.Show();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            book ss = new book();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform ss = new loginform();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            bill ss = new bill();
            ss.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
