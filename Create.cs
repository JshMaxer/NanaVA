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
    public partial class Create : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = NanaVA;username=root;password=;");
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            Random ran = new Random();

            txtnum.Text = "02000" + ran.Next(10,99) + ran.Next(10,99) + ran.Next(10,99);


        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Cancelled cancel = new Cancelled();
            cancel.Show();
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if(txtfirstname.Text.Equals("") || txtlastname.Text.Equals("") || txtmiddlename.Text.Equals("") || txtnum.Text.Equals(""))
            {
                MessageBox.Show("Field is blank ", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string insertQuery = "INSERT INTO information VALUES ('" + txtnum.Text + "','" + txtlastname.Text + "','" + txtfirstname.Text + "','" + txtmiddlename.Text + "')";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Create Successful ", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 f1 = new Form1();
                        f1.Visible = true;
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Create UnSuccessful ", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
