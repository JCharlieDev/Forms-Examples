using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program05_04
{
    public partial class DomainUpDownForm : Form
    {
        public DomainUpDownForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSelectedFruit.Text = "";

            dupFruits.Items.Add("Apples");
            dupFruits.Items.Add("Oranges");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dupFruits.Items.Add(txtAddFruit.Text);

            txtAddFruit.Text = "";
        }

        private void dupFruits_SelectedItemChanged(object sender, EventArgs e)
        {
            //  lblSelectedFruit.Text = dupFruits.Text;

            string fruit = (string)dupFruits.Text;

            lblSelectedFruit.Text = fruit;
            //  lblSelectedFruit.Text = string.Format($"Somethign something {fruit}");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = dupFruits.SelectedIndex;

            dupFruits.Items.RemoveAt(index);

            dupFruits.SelectedIndex = 0;
        }
    }
}
