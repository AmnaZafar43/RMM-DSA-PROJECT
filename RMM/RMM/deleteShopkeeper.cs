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
    public partial class deleteShopkeeper : Form
    {
        public deleteShopkeeper()
        {
            InitializeComponent();
            gvDelete.DataSource = shopkeeperDL.shopkeeperList;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            shopkeeperForm myForm = new shopkeeperForm();
            myForm.ShowDialog();
        }

        private void gvDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (gvDelete.Columns["Delete"].Index == e.ColumnIndex)
                {
                    int index = gvDelete.CurrentCell.RowIndex;
                    shopkeeper user = (shopkeeper)gvDelete.CurrentRow.DataBoundItem;
                    gvDelete.DataSource = null;
                    shopkeeperDL.deleteProduct(user);
                    shopkeeperDL.addToFile();
                    shopkeeperDL.LinkListToList();
                    gvDelete.DataSource = shopkeeperDL.shopkeeperList;
                    gvDelete.Refresh();
                }
            }
            else
            {

            }
        }

        private void deleteShopkeeper_Load(object sender, EventArgs e)
        {

        }
    }
}
