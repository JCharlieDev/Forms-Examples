using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program01_02
{
    public partial class txtName : Form
    {
        public txtName()
        {
            InitializeComponent();
        }

        private void txtName_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            //  Text boxes can be used to read user input.
            lblMessage.Text = "Hello " + txtNameBox.Text + "!!";

        }
    }
}
