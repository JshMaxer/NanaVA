using NanaVA.DBSource;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NanaVA
{
    public partial class Create : Form
    {
        SqlConnection connection = Host.connection;
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            txtnum.Text = "02000" + ran.Next(10, 99) + ran.Next(10, 99) + ran.Next(10, 99);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Cancelled cancel = new Cancelled();
            cancel.Show();
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
                string insertQuery = "INSERT INTO information VALUES ('" + txtnum.Text + "','" + txtlastname.Text + "','" + txtfirstname.Text + "','" + txtmiddlename.Text + "')";
                connection.Close();
                connection.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, connection);

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
