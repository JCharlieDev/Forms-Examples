using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
            lblTbrValue.Text = tbrInterval.Value.ToString();
        }

        private void tmrTest_Tick(object sender, EventArgs e)
        {
            tmrCount++;

            lblValue.Text = tmrCount.ToString();
            lblPbrProgress.Text = pbrJob.Value.ToString();

            if (pbrJob.Value < 100)
            {
                pbrJob.Value++;
            }
            if (pbrJob.Value == 100)
            {
                tmrTest.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrTest.Enabled = true;
            pbrJob.Value = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrTest.Enabled = false;

            tbrInterval.Value = tbrInterval.Minimum;
            lblTbrValue.Text = tbrInterval.Value.ToString();
            tmrTest.Interval = tbrInterval.Value;
        }

        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrTest.Enabled = false;
        }

        private void tbrInterval_Scroll(object sender, EventArgs e)
        {
            lblTbrValue.Text = tbrInterval.Value.ToString();

            tmrTest.Interval = tbrInterval.Value;
        }
        
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100000; i++)
            {
                //  Some proccess.

                if ((i % 1000 == 0))
                {
                    if (pbrJob.Value != pbrJob.Maximum)
                    {
                        Thread.Sleep(100);
                        pbrJob.PerformStep();
                        lblPbrProgress.Text = pbrJob.Value.ToString();
                    }
                    if (pbrJob.Value == pbrJob.Maximum)
                    {
                        Thread.Yield();
                    }
                    
                }

            }

            
        }
    }
}
