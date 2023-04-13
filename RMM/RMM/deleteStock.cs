using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMM.BL;
using RMM.DL;

namespace RMM
{
    public partial class deleteStock : Form
    {
        public deleteStock()
        {
            InitializeComponent();
            gvDelete.DataSource = productDL.productList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewStock myForm = new viewStock();
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
                    product user = (product)gvDelete.CurrentRow.DataBoundItem;
                    gvDelete.DataSource = null;
                    productDL.deleteProduct(user);
                    productDL.addToFile();
                    productDL.LinkListToList();
                    gvDelete.DataSource = productDL.productList;
                    gvDelete.Refresh();                 
                }
            }
            else
            {

            }
        }

        private void deleteStock_Load(object sender, EventArgs e)
        {
           // Console.WriteLine(DL.productDL.productList.Count);
        }
        private void dataBind()
        {
            gvDelete.DataSource = null;
            gvDelete.DataSource = productDL.productList;
            gvDelete.Refresh();
        }

          private void button1_Click(object sender, EventArgs e)
          {

          }
     }
}
