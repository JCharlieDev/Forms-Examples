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
    public partial class Form2 : Form
    {
        private string message;
        private string content;
        public Form2()
        {
            InitializeComponent();
        }

        public string Message
        {
            get
            {
                return message;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            message = txtMessage.Text;
            content = txtContent.Text;
            //  Closes the form but not the instance of it.
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            message = txtMessage.Text;
            content = txtContent.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
