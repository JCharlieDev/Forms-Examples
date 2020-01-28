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
    public partial class Form2 : Form
    {
        private string comment;
        public string Comment
        {
            set
            {
                comment = value;
                lblComment.Text = comment;
            }
        }
            
        //  Constuctor/Form with parameters.
        public Form2(string formMessage)
        {
            InitializeComponent();

            lblMessage.Text = formMessage;
        }
    }
}
