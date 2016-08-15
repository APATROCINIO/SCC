using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCC.View
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pbCarrega.Value < 100)
            {
                pbCarrega.Value = pbCarrega.Value + 5;
            }
            else
            {
                timer1.Enabled = false;
                this.DialogResult = DialogResult.OK;
                this.Visible = false;

            }            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
