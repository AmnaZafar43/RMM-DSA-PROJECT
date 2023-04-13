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
    public partial class updateRider : Form
    {
        public updateRider()
        {
            InitializeComponent();
            gvUpdate.DataSource = riderDL.riderList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            riderForm myForm = new riderForm();
            myForm.ShowDialog();
        }

        private void updateRider_Load(object sender, EventArgs e)
        {

        }
        private void gvUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gvUpdate_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gvUpdate.Columns["Update"].Index == e.ColumnIndex)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update product ?", "Questions", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                if (result == DialogResult.OK)
                {
                    int index = gvUpdate.CurrentCell.RowIndex;
                    rider user = (rider)gvUpdate.CurrentRow.DataBoundItem;
                    gvUpdate.DataSource = null;
                    riderDL.updateProduct(user);
                    riderDL.addToFile();
                    riderDL.LinkListToList();
                    gvUpdate.DataSource = riderDL.riderList;
                    gvUpdate.Refresh();

                }
            }
        }
    }
}
