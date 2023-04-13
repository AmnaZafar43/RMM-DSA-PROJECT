using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class deleteRider : Form
    {
        public deleteRider()
        {
            InitializeComponent();
            gvViewRider.DataSource = riderDL.riderList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            riderForm myForm = new riderForm();
            myForm.ShowDialog();
        }

        private void gvViewRider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (gvViewRider.Columns["Delete"].Index == e.ColumnIndex)
                {
                    int index = gvViewRider.CurrentCell.RowIndex;
                    rider user = (rider)gvViewRider.CurrentRow.DataBoundItem;
                    gvViewRider.DataSource = null;
                    riderDL.deleteProduct(user);
                    riderDL.addToFile();
                    riderDL.LinkListToList();
                    gvViewRider.DataSource = riderDL.riderList;
                    gvViewRider.Refresh();
                }
            }
            else
            {

            }
        }
    }
}
