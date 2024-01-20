using NanaVA.DBSource;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace NanaVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Host.connection;

            connection.Close();
            connection.Open();
            string search = "SELECT first_name, last_name, middle_name, student_number from information WHERE first_name = '" + txtname.Text + "' AND student_number = '" + txtpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(search, connection);
            SqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {

                while (row.Read())
                {
                    string firstname = row["first_name"].ToString();
                    string middlename = row["middle_name"].ToString();
                    string lastname = row["last_name"].ToString();
                    string studentnumber = row["student_number"].ToString();

                    MessageBox.Show("Login Successful Welcome " + firstname, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Oldinfo info = new Oldinfo();

                    Source.UniversalInfo.fname = firstname;
                    Source.UniversalInfo.mname = middlename;
                    Source.UniversalInfo.lname = lastname;
                    Source.UniversalInfo.studentnum = studentnumber;

                    info.Show();
                    this.Visible = false;
                }

                connection.Close();
            }
            else
            {
                MessageBox.Show("Login Denied", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Create cr = new Create();
            cr.Show();
            this.Visible = false;
        }
    }
}
