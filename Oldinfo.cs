using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NanaVA
{
    public partial class Oldinfo : Form
    {
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
            change.txtnum.Text = txtnum.Text;
            this.Close();
        }
    }
}
