using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prorgam02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            ////  Show's the instace of the form (Can create multiple instances of the form).
            //form2.Show();

            //  Show's the instance of the form, more instances cannot be created unless the current one is closed (Modal dialog box).
            form2.ShowDialog();
        }
    }
}
