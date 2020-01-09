using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program01_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (chkKeyboard.Checked == true)
            {
                total += 150;
            }
            if (chkMonitor.Checked == true)
            {
                total += 250;
            }
            if (chkMouse.Checked == true)
            {
                total += 100;
            }

            MessageBox.Show($"Total is: {total} ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkMouse.ForeColor = Color.Green;
            chkMonitor.ForeColor = Color.Green;
            chkKeyboard.ForeColor = Color.Green;

            lblPrice.Text = "";
        }

        private void chkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonitor.Checked == true)
            {
                lblPrice.Text = "Monitor";
            }
            else
            {
                lblPrice.Text = ""; 
            }
        }




        //  Color change on hover
        private void chkMonitor_MouseHover(object sender, EventArgs e)
        {
            chkMonitor.ForeColor = Color.DarkRed;
        }

        private void chkMonitor_MouseLeave(object sender, EventArgs e)
        {
            chkMonitor.ForeColor = Color.Green;
        }

    }
}
