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
    public partial class Change : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog = NanaVA;username=root;password=;");
        public Change()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Cancelled can = new Cancelled();
            can.Show();
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text.Equals("") || txtlastname.Text.Equals("") || txtmiddlename.Text.Equals("") || txtnum.Text.Equals(""))
            {
                MessageBox.Show("Field is blank ", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Submitted submit = new Submitted();
                Oldinfo old = new Oldinfo();

                string updateQuery = "UPDATE information SET first_name = '" + txtfirstname.Text + "', last_name = '" + txtlastname.Text + "', middle_name = '" + txtmiddlename.Text + "'" + "WHERE student_number = " + Convert.ToInt32(txtnum.Text);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account updated", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        submit.txtsecret.Text = txtnum.Text;
                        submit.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Account not updated", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }

        }
    }
}
