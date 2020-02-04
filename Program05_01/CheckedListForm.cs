using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program05_01
{
    public partial class CheckedListForm : Form
    {
        public CheckedListForm()
        {
            InitializeComponent();
        }

        private void CheckedListForm_Load(object sender, EventArgs e)
        {
            lblIndexName.Text = "";

            chlbFood.Items.Add("Meat");
            chlbFood.Items.Add("Fish", true); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chlbFood.Items.Add(txtFood.Text);
        }

        private void chlbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = chlbFood.SelectedIndex;

            //  If no item is selected, index will have a value of -1.
            if (index != -1)
            {
                lblIndexName.Text = chlbFood.Items[index].ToString();
            }

            if (chlbFood.GetItemChecked(3) == true)
            {
                MessageBox.Show("Fish is good");
            }
        }
    }
}
