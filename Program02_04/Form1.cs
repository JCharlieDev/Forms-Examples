using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program02_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            DialogResult result = myForm2.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblMessage.Text = myForm2.Message;
                lblContent.Text = myForm2.Content;
            }
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("No operations executed.", "No Operations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
