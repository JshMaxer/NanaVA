using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NanaVA.DBSource;

namespace NanaVA
{
    public partial class Submitted : Form
    {
        SqlConnection connection = Host.connection;

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
            Oldinfo oldinfo = new Oldinfo();
            this.Close();
            oldinfo.Show();
        }
    }
}
