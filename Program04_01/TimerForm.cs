using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program04_01
{
    public partial class TimerForm : Form
    {
        private int tmrCount;
        public TimerForm()
        {
            InitializeComponent();
            tmrCount = 0;
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            lblValue.Text = "";
        }

        private void tmrTest_Tick(object sender, EventArgs e)
        {
            tmrCount++;

            lblValue.Text = tmrCount.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrTest.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrTest.Enabled = false;
        }

        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrTest.Enabled = false;
        }
    }
}
