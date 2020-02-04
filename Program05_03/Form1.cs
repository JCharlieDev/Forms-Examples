using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program05_03
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //  Add new file.

            int n = dtgvProducts.Rows.Add();

            //  Adds data.

            dtgvProducts.Rows[n].Cells[0].Value = txtProductCode.Text;
            dtgvProducts.Rows[n].Cells[1].Value = txtProductName.Text;
            dtgvProducts.Rows[n].Cells[2].Value = txtProductPrice.Text;

            //  Clears fields.

            txtProductPrice.Text = "";
            txtProductName.Text = "";
            txtProductCode.Text = "";
        }

        private void dtgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //  Index header is -1;
            n = e.RowIndex;

            if (n != -1)
            {
                lblInfo.Text = (string)dtgvProducts.Rows[n].Cells[1].Value;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvProducts.Rows.RemoveAt(n);
            }
        }
    }
}
