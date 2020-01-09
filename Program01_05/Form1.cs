using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program01_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";

            txtA.Text = "0";
            txtB.Text = "0";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double result = 0.0;
            double a = 0.0;
            double b = 0.0;

            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            if (rbSum.Checked == true)
            {
                result = a + b;
            }
            if (rbSub.Checked == true)
            {
                result = a - b;
            }
            if (rbDiv.Checked == true)
            {
                result = a / b;
            }
            if (rbMult.Checked == true)
            {
                result = a * b;
            }

            lblResult.Text = result.ToString();
        }

        //  Usually radio buttons are located inside group boxes.
    }
}
