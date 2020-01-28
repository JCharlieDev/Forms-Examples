using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetPrice_Click(object sender, EventArgs e)
        {
            double cost = 0.0;
            string pricing = "";

            pricing = $"Car Assurance to: {txtName.Text} \r\n";

            //  Initial cost.
            cost = Convert.ToDouble(txtCost.Text);

            //  Assurance verification.

            if (rbtnBasic.Checked == true)
            {
                cost += 500.0;

                pricing += "Pricing of 'Basic Assurance' is 500$ \r\n ";
            }
            if (rbtnThirdP.Checked == true)
            {
                cost += 700.0;

                pricing += "Pricing of 'Third Party Assurance' is 700$ \r\n";
            }
            if (rbtnTotal.Checked == true)
            {
                cost += 1000.0;

                pricing += "Pricing total is 700$ \r\n";
            }

            //  Equipement verification

            if (chkAirCond.Checked == true)
            {
                cost += 500.0;

                pricing += "Pricing of 'Air Conditioning' is 500$ \r\n";
            }

            if (chkAudio.Checked == true)
            {
                cost += 700;

                pricing += "Pricing of 'Audio System' is 700$ \r\n";
            }

            //  Show's Total.

            pricing += $"Total to pay is: {cost.ToString()}";

            txtPricing.Text = pricing;
        }
    }
}
