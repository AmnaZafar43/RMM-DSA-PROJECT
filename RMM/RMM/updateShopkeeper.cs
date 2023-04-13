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
    public partial class updateShopkeeper : Form
    {
        public updateShopkeeper()
        {
            InitializeComponent();
            gvUpdate.DataSource = shopkeeperDL.shopkeeperList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            shopkeeperForm myForm = new shopkeeperForm();
            myForm.ShowDialog();
        }

        private void gvUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvUpdate.Columns["Update"].Index == e.ColumnIndex)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update product ?", "Questions", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                if (result == DialogResult.OK)
                {
                    int index = gvUpdate.CurrentCell.RowIndex;
                    shopkeeper user = (shopkeeper)gvUpdate.CurrentRow.DataBoundItem;
                    gvUpdate.DataSource = null;
                    shopkeeperDL.updateProduct(user);
                    shopkeeperDL.addToFile();
                    shopkeeperDL.LinkListToList();
                    gvUpdate.DataSource = shopkeeperDL.shopkeeperList;
                    gvUpdate.Refresh();

                }
            }
        }
    }
}
