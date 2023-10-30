using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace ContactManager_WinFormApp
{
    public partial class SignUpForm : Form
    {
        string email_pattern = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$";
        string pass_pattern = @"(?=^.{8,}$)((?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void idtb_Enter(object sender, EventArgs e)
        {
            if (idtb.Text == "Enter your id")
            {
                idtb.Text = string.Empty;
                idtb.ForeColor = Color.Black;

            }
        }

        private void idtb_Leave(object sender, EventArgs e)
        {
            if (idtb.Text == string.Empty)
            {

                idtb.Focus();
                errorProvider1.SetError(this.idtb, "Enter your id!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void idtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void nametb_Enter(object sender, EventArgs e)
        {
            if (nametb.Text == "Enter your full name")
            {
                nametb.Text = string.Empty;
                nametb.ForeColor = Color.Black;

            }
        }

        private void nametb_Leave(object sender, EventArgs e)
        {
            if (nametb.Text == string.Empty)
            {

                nametb.Focus();
                errorProvider2.SetError(this.nametb, "Enter your full name!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void nametb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void genderCb_Leave(object sender, EventArgs e)
        {
            if (genderCb.SelectedItem == null)
            {
                genderCb.Focus();
                errorProvider3.SetError(this.genderCb, "Select your gender!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void ageBox_Leave(object sender, EventArgs e)
        {
            if (ageBox.Value == 0)
            {
                ageBox.Focus();
                errorProvider4.SetError(this.ageBox, "Enter your age!");
            }
            else
            {
                errorProvider4.Clear();
            }
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
            if (Regex.IsMatch(emailtb.Text, email_pattern) == false)
            {
                emailtb.Focus();
                errorProvider5.SetError(this.emailtb, "Enter valid email!");
            }
            else
            {
                errorProvider5.Clear();
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
            if (Regex.IsMatch(passwordtb.Text, pass_pattern) == false)
            {
                passwordtb.Focus();
                errorProvider6.SetError(this.passwordtb, "Enter strong password, Uppercase, lowercase, numbers & special char combination!");

            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void cpasswordtb_Enter(object sender, EventArgs e)
        {
            if (cpasswordtb.Text == "Re-enter password")
            {
                cpasswordtb.Text = string.Empty;
                cpasswordtb.ForeColor = Color.Black;
            }
        }

        private void cpasswordtb_Leave(object sender, EventArgs e)
        {
            if (cpasswordtb.Text != passwordtb.Text)
            {
                cpasswordtb.Focus();
                errorProvider7.SetError(this.cpasswordtb, "Re-enter the same password!");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:
                    passwordtb.UseSystemPasswordChar = false;
                    cpasswordtb.UseSystemPasswordChar = false;
                    break;
                default:
                    passwordtb.UseSystemPasswordChar = true;
                    cpasswordtb.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idtb.Text) == true)
            {
                idtb.Focus();
                errorProvider1.SetError(this.idtb, "Enter your id!");
            }
            else if (string.IsNullOrEmpty(nametb.Text))
            {
                nametb.Focus();
                errorProvider2.SetError(this.nametb, "Enter your name!");
            }
            else if (genderCb.SelectedItem == null)
            {
                genderCb.Focus();
                errorProvider3.SetError(this.genderCb, "Choose your gender!");
            }
            else if (ageBox.Value == 0)
            {
                ageBox.Focus();
                errorProvider4.SetError(this.ageBox, "Enter your age!");
            }
            else if (Regex.IsMatch(emailtb.Text, email_pattern) == false)
            {
                emailtb.Focus();
                errorProvider5.SetError(this.emailtb, "Enter valid email!");
            }

            else if (Regex.IsMatch(passwordtb.Text, pass_pattern) == false)
            {
                passwordtb.Focus();
                errorProvider6.SetError(this.passwordtb, "Enter strong password, Uppercase, lowercase, numbers & special char combination!");
            }
            else if (cpasswordtb.Text != passwordtb.Text)
            {
                cpasswordtb.Focus();
                errorProvider7.SetError(this.cpasswordtb, "Re-enter same password!");
            }
            else
            {

                SqlConnection conn = new SqlConnection(cs);

                //below code is for checking if a user with the 
                //same id already exist then it will display
                //a message that a user already exist.
                string query = "SELECT * FROM Users where U_id = @uid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", idtb.Text);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    MessageBox.Show("User with id = " + idtb.Text + " already exist!!!", "Duplication Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetControls();
                }
                else
                {
                    conn.Close();
                    string query2 = "INSERT INTO Users VALUES (@id,@name,@gender,@age,@email,@password)";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@id", idtb.Text);
                    cmd2.Parameters.AddWithValue("@name", nametb.Text);
                    cmd2.Parameters.AddWithValue("@gender", genderCb.SelectedItem);
                    cmd2.Parameters.AddWithValue("@age", ageBox.Value);
                    cmd2.Parameters.AddWithValue("@email", emailtb.Text);
                    cmd2.Parameters.AddWithValue("@password", passwordtb.Text);

                    conn.Open();

                    int a = cmd2.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Sign up completed successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetControls();
                        LoginForm loginForm = new LoginForm();
                        this.Hide();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sign up Failed!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }

                void ResetControls()
                {
                    idtb.Clear();
                    nametb.Clear();
                    genderCb.SelectedItem = null;
                    ageBox.Value = 0;
                    emailtb.Clear();
                    passwordtb.Clear();
                    cpasswordtb.Clear();
                    checkBox1.Checked = false;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
