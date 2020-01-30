using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program03_01
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult about = MessageBox.Show("Menu Example", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double variableA = Convert.ToDouble(txtVariableA.Text);
            double variableB = Convert.ToDouble(txtVariableB.Text);

            double sum = variableA + variableB;

            txtResult.Text = sum.ToString();

            slblValues.Text = $"A = {variableA}, B = {variableB}";
            slblOperation.Text = $"Operation: Sum";
            slblResult.Text = $"Result: {sum}";
        }

        private void substractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double variableA = Convert.ToDouble(txtVariableA.Text);
            double variableB = Convert.ToDouble(txtVariableB.Text);

            double sub = variableA - variableB;

            txtResult.Text = sub.ToString();

            slblValues.Text = $"A = {variableA}, B = {variableB}";
            slblOperation.Text = $"Operation: Substraction";
            slblResult.Text = $"Result: {sub}";
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double variableA = Convert.ToDouble(txtVariableA.Text);
            double variableB = Convert.ToDouble(txtVariableB.Text);

            double mult = variableA * variableB;

            txtResult.Text = mult.ToString();

            slblValues.Text = $"A = {variableA}, B = {variableB}";
            slblOperation.Text = $"Operation: Multiplication";
            slblResult.Text = $"Result: {mult}";
        }

        private void divitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double variableA = Convert.ToDouble(txtVariableA.Text);
            double variableB = Convert.ToDouble(txtVariableB.Text);

            double div = variableA / variableB;

            txtResult.Text = div.ToString();

            slblValues.Text = $"A = {variableA}, B = {variableB}";
            slblOperation.Text = $"Operation: Divition";
            slblResult.Text = $"Result: {div}";
        }

        private void enableToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
                txtVariableA.Enabled = enableToolStripMenuItem.Checked;
                txtVariableB.Enabled = enableToolStripMenuItem.Checked;
        }

        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtVariableA.Text = "0";
        }

        private void randNumbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            int number = randNum.Next(0, 100);

            txtVariableA.Text = number.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtVariableB.Text = "0";
        }

        private void randNumbStripMenuItem2_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            int number = randNum.Next(0, 100);

            txtVariableB.Text = number.ToString();
        }
    }
}
