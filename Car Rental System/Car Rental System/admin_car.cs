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
    public partial class admin_car : Form
    {
        public admin_car()
        {
            InitializeComponent();
        }

        private void admin_car_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            if (e.RowIndex + 1 == dataGridView1.Rows.Count) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            bookingidtxt.Text = row.Cells[0].Value.ToString();
            categoryBox1.Text = row.Cells[1].Value.ToString();
            modeltxt.Text = row.Cells[5].Value.ToString();
            maketxt.Text = row.Cells[3].Value.ToString();
            drivertxt.Text = row.Cells[4].Value.ToString();
            availableBox.Text = row.Cells[2].Value.ToString();*/
            
        }
    }
}
