using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;        // Database library 

namespace TripPlanner
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = dbtravel.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void SignUp_Load(object sender, EventArgs e)
        {
            textBoxPasswordUp.PasswordChar = '*';
            textBoxConfirmPassword.PasswordChar = '*';
        }

        private void textBoxUsernameUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxUsernameUp.Text == "" || textBoxPasswordUp.Text == "" || textBoxEmail.Text == "" || textBoxPhoneNumber.Text == "" || textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Registration Failed, please enter your full details");
            }

            else if (textBoxPasswordUp.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords does not match, please re-enter the password");
                textBoxPasswordUp.Text = "";
                textBoxConfirmPassword.Text = "";
                textBoxPasswordUp.Focus();
            }

            else
            {
                con.Open();         // sends the user's credentials and information to the Database

                string reg = "INSERT INTO tbl_users VALUES ('" + textBoxUsernameUp.Text + "','" + textBoxPasswordUp.Text + "','" + textBoxEmail.Text + "','" + textBoxPhoneNumber.Text + "')";
                
                try         //Exception handling if the user already have an account
                {
                    cmd = new OleDbCommand(reg, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Account is already registered");

                }

                finally
                {
                    WelcomePage welcomePage = new WelcomePage();
                    welcomePage.Show();
                    this.Hide();
                }
            }
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPasswordUp.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPasswordUp.PasswordChar = '*';
                textBoxConfirmPassword.PasswordChar = '*';
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            WelcomePage welcome = new WelcomePage();
            welcome.Show();
            this.Hide();
        }
    }
}
