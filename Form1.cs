using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NanaVA
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = NanaVA;username=root;password=;");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            string search = "SELECT first_name, last_name, middle_name, student_number from information WHERE first_name = '" + txtname.Text + "' AND student_number = '" + txtpassword.Text + "'";
            MySqlCommand cmd = new MySqlCommand(search, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if(row.HasRows)
            {

                while(row.Read())
                {
                    string firstname = row["first_name"].ToString();
                    string lastname = row["last_name"].ToString();
                    string middle = row["middle_name"].ToString();
                    string stu = row["student_number"].ToString();

                    MessageBox.Show("Login Successful Welcome " + firstname, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    Oldinfo info = new Oldinfo();

                    info.txtlastname.Text = lastname;
                    info.txtfirstname.Text = firstname;
                    info.txtmiddlename.Text = middle;
                    info.txtnum.Text = stu;

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
