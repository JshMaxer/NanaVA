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
    public partial class Cancelled : Form
    {
        public Cancelled()
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
            Form1 f1 = new Form1();
            this.Close();

            f1.Visible = true;
            
        }
    }
}
