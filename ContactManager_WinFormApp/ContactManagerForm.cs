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
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ClosedXML.Excel;

namespace ContactManager_WinFormApp
{
    public partial class ContactManagerForm : Form
    {
        int id;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        string email_pattern = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$";
        public ContactManagerForm()
        {
            InitializeComponent();
        }

        private void nametb_Enter(object sender, EventArgs e)
        {
            if (nametb.Text == "Enter name here")
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
                errorProvider1.SetError(this.nametb, "Enter name here!");
            }
            else
            {
                errorProvider1.Clear();
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
                errorProvider2.SetError(this.emailtb, "Enter valid email!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void phonenumtb_Enter(object sender, EventArgs e)
        {
            if (phonenumtb.Text == "Enter phone number")
            {
                phonenumtb.Text = string.Empty;
                phonenumtb.ForeColor = Color.Black;

            }
        }

        private void phonenumtb_Leave(object sender, EventArgs e)
        {
            if (phonenumtb.Text == string.Empty)
            {

                phonenumtb.Focus();
                errorProvider3.SetError(this.phonenumtb, "Enter phone number!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void phonenumtb_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void signupidtb_Enter(object sender, EventArgs e)
        {
            if (signupidtb.Text == "Enter your signup id")
            {
                signupidtb.Text = string.Empty;
                signupidtb.ForeColor = Color.Black;

            }
        }

        private void signupidtb_Leave(object sender, EventArgs e)
        {

            if (signupidtb.Text == string.Empty)
            {

                signupidtb.Focus();
                errorProvider4.SetError(this.signupidtb, "Enter your signup id!");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void signupidtb_KeyPress(object sender, KeyPressEventArgs e)
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


        //to show data in  gridview
        void BindGridViewSignUp()
        {

            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT U_id, Name, Gender FROM Users";


            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            sda.Fill(data);


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = data;

        }

        private void Signupidbtn_Click(object sender, EventArgs e)
        {
            BindGridViewSignUp();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(nametb.Text))
            {
                nametb.Focus();
                errorProvider1.SetError(this.nametb, "Enter name here!");
            }
            else if (Regex.IsMatch(emailtb.Text, email_pattern) == false)
            {
                emailtb.Focus();
                errorProvider2.SetError(this.emailtb, "Enter valid email!");
            }
            else if (phonenumtb.Text == string.Empty)
            {

                phonenumtb.Focus();
                errorProvider3.SetError(this.phonenumtb, "Enter phone number!");
            }
            else if (string.IsNullOrEmpty(signupidtb.Text) == true)
            {
                signupidtb.Focus();
                errorProvider4.SetError(this.signupidtb, "Enter your signup id!");
            }
            else
            {

                SqlConnection conn = new SqlConnection(cs);
                
                
                    conn.Close();
                    string query = "INSERT INTO ContactsList VALUES (@name,@email,@phoneNum,@signupid)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    
                    cmd.Parameters.AddWithValue("@name", nametb.Text);
                    cmd.Parameters.AddWithValue("@email", emailtb.Text);
                    cmd.Parameters.AddWithValue("@phoneNum", phonenumtb.Text);
                    cmd.Parameters.AddWithValue("@signupid", signupidtb.Text);

                    conn.Open();

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Contact Saved successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        WholeContactList();
                        ResetControls();
                    }
                    else
                    {
                        MessageBox.Show("Contact Failed to save!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
               



           
           

        }
        void ResetControls()
        {
            signupidtb.Clear();
            nametb.Clear();
            emailtb.Clear();
            phonenumtb.Clear();

        }

        private void viewlisttb_Enter(object sender, EventArgs e)
        {
            if (viewlisttb.Text == "Enter your signup id")
            {
                viewlisttb.Text = string.Empty;
                viewlisttb.ForeColor = Color.Black;

            }
        }

        private void viewlisttb_Leave(object sender, EventArgs e)
        {
            if (viewlisttb.Text == string.Empty)
            {

                viewlisttb.Focus();
                errorProvider7.SetError(this.viewlisttb, "Enter your signup id!");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void viewlisttb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ViewListbtn_Click(object sender, EventArgs e)
        {
            if (viewlisttb.Text == string.Empty)
            {

                viewlisttb.Focus();
                errorProvider7.SetError(this.viewlisttb, "Enter your signup id!");
            }
            else
            {
                BindGridViewToContactList();
            }
        }


        //to let user see his own contact list through his signup id
        private void BindGridViewToContactList()
        {
            if (viewlisttb.Text == string.Empty)
            {

                viewlisttb.Focus();
                errorProvider7.SetError(this.viewlisttb, "Enter your signup id!");
            }
            else
            {


                SqlConnection conn = new SqlConnection(cs);
                string query = "SELECT Name,Email,Phone_number FROM ContactsList WHERE  SignUp_id = @signupid";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@signupid", viewlisttb.Text);

                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count == 0)
                {

                    MessageBox.Show("No Contact found for the specified user ID.", "No Contact found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView2.DataSource = data;
                    viewlisttb.Clear();
                }




                conn.Close();
            }
           

        }

        private void viewsignupbtn_Click(object sender, EventArgs e)
        {
            BindGridViewSignUp2();
        }

        void BindGridViewSignUp2()
        {

            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT U_id, Name, Gender FROM Users";


            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            sda.Fill(data);


            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = data;

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
          

            ResetControls();

            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            nametb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            emailtb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            phonenumtb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //signupidtb.valye = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);

        }
   

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void veiwWholeListbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT * FROM ContactsList";


            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            sda.Fill(data);


            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = data;



        }

       

        private void FetchWholeContactListbtn_Click(object sender, EventArgs e)
        {
            WholeContactList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "UPDATE ContactsList SET Name = @name, Email = @email, Phone_number = @phonenum WHERE Contact_id = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Name", nametb.Text);
            cmd.Parameters.AddWithValue("@Email", emailtb.Text);
            cmd.Parameters.AddWithValue("@phonenum", phonenumtb.Text);
            //cmd.Parameters.AddWithValue("@signupid", signupidtb.Text);

            conn.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Contact Updated successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WholeContactList();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Failed to update the Contact!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        void WholeContactList()
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT * FROM ContactsList";


            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable data = new DataTable();
            sda.Fill(data);


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = data;
           

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "DELETE FROM ContactsList WHERE Contact_id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);


            conn.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                DialogResult confirm = MessageBox.Show("Are you sure want to delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    MessageBox.Show("Data Deleted successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WholeContactList();
                    ResetControls();
                }

            }
            else
            {
                MessageBox.Show("Data Deletion Failed!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT * FROM ContactsList WHERE Name like @name + '%' or Email like @email + '%' or Phone_number like @phonenum + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            sda.SelectCommand.Parameters.AddWithValue("@name", searchtb.Text);
            sda.SelectCommand.Parameters.AddWithValue("@email", searchtb.Text);
            sda.SelectCommand.Parameters.AddWithValue("@phonenum", searchtb.Text);




            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = data;

            }

            else
            {
                MessageBox.Show("No Contact found", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT * FROM ContactsList WHERE Name like @name + '%' or Email like @email + '%' or Phone_number like @phonenum + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@name", searchtb.Text);
            sda.SelectCommand.Parameters.AddWithValue("@email", searchtb.Text);
            sda.SelectCommand.Parameters.AddWithValue("@phonenum", searchtb.Text);




            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = data;

            }

            else
            {
                MessageBox.Show("No Contact found", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(cs);
                        string query = "SELECT * FROM ContactsList";

                        SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        sda.Fill(dataTable);

                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(dataTable, "ContactsList");
                            workbook.SaveAs(sfd.FileName);
                        }

                            MessageBox.Show("Contact List exported Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Contact List Failed to export!",ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }

        }
    }
    
}
