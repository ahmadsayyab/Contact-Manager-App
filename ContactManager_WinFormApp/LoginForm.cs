using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ContactManager_WinFormApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void emailtb_Enter(object sender, EventArgs e)
        {
            if (emailtb.Text == "Enter email address")
            {
                emailtb.Text = string.Empty;
                emailtb.ForeColor = Color.Black;
            }
        }

        private void emailtb_Leave(object sender, EventArgs e)
        {
            if (emailtb.Text == string.Empty)
            {
                emailtb.Text = "Enter Email here";
                emailtb.ForeColor = Color.Gray;
            }
        }

        private void passwordtb_Enter(object sender, EventArgs e)
        {
            if (passwordtb.Text == "Enter password")
            {
                passwordtb.Text = string.Empty;
                passwordtb.ForeColor = Color.Black;
            }
        }

        private void passwordtb_Leave(object sender, EventArgs e)
        {
            if (passwordtb.Text == string.Empty)
            {
                passwordtb.Text = "Enter password";
                passwordtb.ForeColor = Color.Gray;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:
                    passwordtb.UseSystemPasswordChar = false;

                    break;
                default:
                    passwordtb.UseSystemPasswordChar = true;

                    break;
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (emailtb.Text != string.Empty && passwordtb.Text != string.Empty)
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection conn = new SqlConnection(cs);
                string query = "SELECT * FROM Users WHERE Email = @email and Password = @pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", emailtb.Text);
                cmd.Parameters.AddWithValue("@pass", passwordtb.Text);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {

                    
                    ContactManagerForm contactManagerForm = new ContactManagerForm();
                    this.Hide();
                    contactManagerForm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Login failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Enter data in both the fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.Show();
        }
    }

       
    }

