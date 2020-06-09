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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {

            string firstname = fName.Text;
            string Lastname = lName.Text;
            string e_mail = emailtxt1.Text;
            string cnic2 = cnictxt.Text;
            string contact_no = contactNotxt.Text;
            string password = passwordtxt1.Text;
            string c_password = cpasswordtxt.Text;
            string membership_id = membershipid.Text;
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6FG9FQD;Initial Catalog=CarRentalSystemDBMSProject;Integrated Security=True");
            con.Open();

            string query= "insert into CUSTOMER_DETAILS(CNIC, FNAME, LNAME, PHONE_NUMBER, EMAIL_ID, PASSWORD1, MEMBERSHIP_ID) " +
                "values(@cnic1, @firstname1, @lastname1, @phoneno1, @emailaddress1, @userpassword, @membershipid1)";
            
                SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@cnic1", cnic2);
            cmd.Parameters.AddWithValue("@firstname1", firstname);
            cmd.Parameters.AddWithValue("@lastname1", Lastname);
            cmd.Parameters.AddWithValue("@phoneno1", contact_no);
            cmd.Parameters.AddWithValue("@emailaddress1", e_mail);
            cmd.Parameters.AddWithValue("@userpassword", password);
            cmd.Parameters.AddWithValue("@membershipid1", membership_id);


            if (password == c_password)
            {
                warning.ForeColor = Color.Green;
                warning.Text = "All set to signup!";

                this.Hide();
                Form2 ss = new Form2();
                ss.Show();

                
                MessageBox.Show("Registered Successfully.");
                
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                warning.ForeColor = Color.Red;
                warning.Text = "Password didn't match.";
              
            }

        }

        private void cpasswordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                passwordtxt1.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtxt1.UseSystemPasswordChar = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cpasswordtxt.UseSystemPasswordChar = false;
            }
            else
            {
                cpasswordtxt.UseSystemPasswordChar = true;
            }
        }
    }
}
