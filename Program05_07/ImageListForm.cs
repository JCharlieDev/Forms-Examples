using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program05_07
{
    public partial class ImageListForm : Form
    {
        private int index = 0;
        public ImageListForm()
        {
            InitializeComponent();
            index = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;

            if (index >= imglPictures.Images.Count)
            {
                index = imglPictures.Images.Count;
            }

            lblPicture.ImageIndex = index;

            if (index != imglPictures.Images.Count)
            {
                picbPicture.Image = imglPictures.Images[index];
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index--;

            if (index <= 0)
            {
                index = 0;
            }

            lblPicture.ImageIndex = index;
            picbPicture.Image = imglPictures.Images[index];
        }

        private void ImageListForm_Load(object sender, EventArgs e)
        {
            picbPicture.Image = imglPictures.Images[index];
        }
    }
}
