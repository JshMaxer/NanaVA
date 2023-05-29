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
    public partial class Submitted : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = NanaVA;username=root;password=;");
        public Submitted()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rgbtrans.AutoTransition = true;
            rgbtranslight.AutoTransition = true;

            rgbline.FillColor2 = rgbtranslight.Value;
            rgbline.FillColor = rgbtrans.Value;
        }

        private void timerclose_Tick(object sender, EventArgs e)
        {
            connection.Close();
            Oldinfo old = new Oldinfo();

            string showQuery = "SELECT first_name, last_name, middle_name, student_number FROM information WHERE student_number = '" + txtsecret.Text + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(showQuery, connection);
            MySqlDataReader row = cmd.ExecuteReader();
            
            if(row.Read())
            {
                old.txtfirstname.Text = row.GetString("first_name");
                old.txtlastname.Text = row.GetString("last_name");
                old.txtmiddlename.Text = row.GetString("middle_name");
                old.txtnum.Text = row.GetString("student_number");
                old.Show();
                this.Close();
            }
            else
            {
                old.txtfirstname.Text = "";
                old.txtlastname.Text = "";
                old.txtmiddlename.Text = "";
                old.txtnum.Text = "";
                MessageBox.Show("Error");
            }
            connection.Close();
        }
    }
}
