using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program05_02
{
    public partial class ComboBoxForm : Form
    {
        public ComboBoxForm()
        {
            InitializeComponent();
        }

        private void ComboBoxForm_Load(object sender, EventArgs e)
        {
            lblIndex.Text = "";
            lblText.Text = "";

            cmbFood.Items.Add("Fish");
            cmbFood.Items.Add("Milk");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                cmbFood.Items.Add(txtAddFood.Text);
        }

        private void cmbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbFood.SelectedIndex;

            lblIndex.Text = index.ToString();
            lblText.Text = cmbFood.Items[index].ToString();
        }
    }
}
