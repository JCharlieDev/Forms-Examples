using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program02_03
{
    public partial class Form1 : Form
    {
        Form2 myForm2 = new Form2("");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //  The instantiated form will be initialized with the parameters that were sent.
            //  Form2 myForm2 = new Form2(txtMessage.Text);

            myForm2.Comment = txtMessage.Text;

            myForm2.Show();
        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            myForm2.Comment = txtMessage.Text;
        }
    }
}
