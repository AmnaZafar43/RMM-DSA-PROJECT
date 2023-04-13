using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Presentation;
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
    public partial class deleteEmployee : Form
    {
        public deleteEmployee()
        {
            InitializeComponent();
            gvdelete.DataSource = employeeDL.employeeList;
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashManager myForm = new dashManager();
            myForm.ShowDialog();
        }

        private void gvdelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (gvdelete.Columns["Delete"].Index == e.ColumnIndex)
                {
                    int index = gvdelete.CurrentCell.RowIndex;
                    employee user = (employee)gvdelete.CurrentRow.DataBoundItem;
                    gvdelete.DataSource = null;
                    employeeDL.deleteEmployee(user);
                    employeeDL.addToFile();
                    employeeDL.LinkListToList();
                    gvdelete.DataSource = employeeDL.employeeList;
                    gvdelete.Refresh();
                }
            }
            else
            {

            }
        }
    }
}
