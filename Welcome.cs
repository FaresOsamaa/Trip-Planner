using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;       // Database library 

namespace TripPlanner
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = dbtravel.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public void SignUpButton_Click(object sender, EventArgs e)  //
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        public void SignInButton_Click(object sender, EventArgs e)
        {
                if (con.State == ConnectionState.Closed)    //cheking if the Data Base connection is closed or opened
                {
                    con.Open();
                }

            string sign_in = "SELECT * FROM tbl_users WHERE Username= '" + textBoxUser.Text + "' and Password= '" + textBoxPassword.Text + "'";
            cmd = new OleDbCommand(sign_in, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                Trips plans = new Trips();
                plans.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUser.Text = "";
                textBoxPassword.Text = "";
            }
        }
        public void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';     //setting default Password textbox to '*'
        }
    }
}
