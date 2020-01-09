using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program01_06
{
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ////  Typical message box.
            //MessageBox.Show("Hello everyone!");

           DialogResult dialogResult = MessageBox.Show("Testing buttons", "Different buttons", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Cancel)
            {
                lblMessage.Text = "'Cancel' Button was clicked.";
            }
            if (dialogResult == DialogResult.Yes)
            {
                lblMessage.Text = "'Yes' Button was clicked.";
            }
            if (dialogResult == DialogResult.No)
            {
                lblMessage.Text = "'No' Button was clicked.";
            }
        }
    }
}