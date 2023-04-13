using RMM.BL;
using RMM.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMM
{
    public partial class updateStock : Form
    {
        public updateStock()
        {
            InitializeComponent();
            gvUpdate.DataSource = productDL.productList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewStock myForm = new viewStock();
            myForm.ShowDialog();
        }

        private void gvDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvUpdate.Columns["Update"].Index == e.ColumnIndex)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update product ?", "Questions", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                if (result == DialogResult.OK)
                {
                    int index = gvUpdate.CurrentCell.RowIndex;
                    product user = (product)gvUpdate.CurrentRow.DataBoundItem;
                    gvUpdate.DataSource = null;
                    productDL.updateProduct(user);
                    productDL.addToFile();
                    productDL.LinkListToList();
                    gvUpdate.DataSource = productDL.productList;
                    gvUpdate.Refresh();

                }
            }
        }

        private void updateStock_Load(object sender, EventArgs e)
        {

        }
    }
}
