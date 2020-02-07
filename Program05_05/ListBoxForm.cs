using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program05_05
{
    public partial class ListBoxForm : Form
    {
        public ListBoxForm()
        {
            InitializeComponent();
        }

        private void ListBoxForm_Load(object sender, EventArgs e)
        {
            lblSelectedItem.Text = string.Empty;

            //  Element addition
            lstFruits.Items.Add("Orange");
            lstFruits.Items.Add("Banana");
            lstFruits.Items.Add("Grapes");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstFruits.Items.Add(txtFruitAdd.Text);

            txtFruitAdd.Text = string.Empty;    //  Same as = "";
        }

        private void lstFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFruits.SelectedIndex != -1)
            {
                lblSelectedItem.Text = (string)lstFruits.Items[lstFruits.SelectedIndex];
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstFruits.SelectedIndex != -1)
            {
                lstFruits.Items.RemoveAt(lstFruits.SelectedIndex);
            }
        }
    }
}
