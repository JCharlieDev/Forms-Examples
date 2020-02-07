using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program05_08
{
    public partial class ListViewForm : Form
    {
        ListViewGroup fruits = new ListViewGroup("Fruits", HorizontalAlignment.Left);
        ListViewGroup meats = new ListViewGroup("Meats", HorizontalAlignment.Left);

        public ListViewForm()
        {
            InitializeComponent();
        }

        private void ListViewForm_Load(object sender, EventArgs e)
        {
            lstvFood.Groups.Add(fruits);
            lstvFood.Groups.Add(meats);

            lstvFood.Items.Add(new ListViewItem("Apple", fruits));
            lstvFood.Items.Add(new ListViewItem("Watermelon", fruits));
            lstvFood.Items.Add(new ListViewItem("Grape", fruits));
            lstvFood.Items.Add(new ListViewItem("Orange", fruits));

            //  Other way of adding.
            ListViewItem myItem = new ListViewItem("Bacon", meats);

            lstvFood.Items.Add(myItem);
            lstvFood.Items.Add(new ListViewItem("Chicken", meats));
            lstvFood.Items.Add(new ListViewItem("Pork", meats));
            lstvFood.Items.Add(new ListViewItem("Turkey", meats));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbtnFruits.Checked == true)
            {
                lstvFood.Items.Add(new ListViewItem(txtAddElement.Text, fruits));
            }
            if (rbtnMeats.Checked == true)
            {
                lstvFood.Items.Add(new ListViewItem(txtAddElement.Text, meats));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
