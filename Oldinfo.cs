using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NanaVA.DBSource;

namespace NanaVA
{
    public partial class Oldinfo : Form
    {
        SqlConnection connection = Host.connection;

        public Oldinfo()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Cancelled cancel = new Cancelled();
            cancel.Show();
            this.Close();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            Change change = new Change();
            change.Show();
            this.Close();
        }

        private void Oldinfo_Load(object sender, EventArgs e)
        {
            txtfirstname.Text = Source.UniversalInfo.fname;
            txtmiddlename.Text = Source.UniversalInfo.mname;
            txtlastname.Text = Source.UniversalInfo.lname;
            txtnum.Text = Source.UniversalInfo.studentnum;
        }
    }
}
