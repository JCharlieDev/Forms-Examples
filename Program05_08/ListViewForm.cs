using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            lblSelected.Text = "";
            //  Creates an ImageList

            ImageList myImages = new ImageList();
            myImages.ImageSize = new Size(100, 100);

            //  We get the list of images.
            string[] files = Directory.GetFiles("C:\\Users\\MSI\\Desktop\\GitHub Repos\\Forms-Examples\\Program05_08\\Images");

            //  We load the files

            try
            {
                foreach (string file in files)
                {
                    myImages.Images.Add(Image.FromFile(file));
                }
            }
            catch
            {

                MessageBox.Show("Something went wrong at load time");
            }

            lstvFood.SmallImageList = myImages;

            lstvFood.Groups.Add(fruits);
            lstvFood.Groups.Add(meats);

            lstvFood.Items.Add(new ListViewItem("Apple", 0, fruits));
            lstvFood.Items.Add(new ListViewItem("Watermelon", 5, fruits));
            lstvFood.Items.Add(new ListViewItem("Grape", 2, fruits));
            lstvFood.Items.Add(new ListViewItem("Banana", 1, fruits));

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

        private void lstvFood_MouseClick(object sender, MouseEventArgs e)
        {
            lblSelected.Text = lstvFood.SelectedItems[0].SubItems[0].Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstvFood.Items.Clear();
            lblSelected.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lstvFood.SelectedItems[0].SubItems[0].Text = txtAddElement.Text;
            lstvFood.SelectedItems[0].ImageIndex = Convert.ToInt32(txtImage.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "";
            lstvFood.Items.RemoveAt(lstvFood.SelectedIndices[0]);
        }
    }
}
