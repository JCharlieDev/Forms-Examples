using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program05_06
{
    public partial class PictureBoxForm : Form
    {
        public PictureBoxForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Image loadImage = Image.FromFile("C:\\Users\\MSI\\Desktop\\GitHub Repos\\Forms-Examples\\Program05_06\\Resources\\Images\\Programming.jpg");

            picImage.Image = loadImage;
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
