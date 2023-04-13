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
    public partial class updateEmployee : Form
    {
        public updateEmployee()
        {
            InitializeComponent();
            gvUpdate.DataSource = employeeDL.employeeList;
        }

        private void updateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void gvUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvUpdate.Columns["Update"].Index == e.ColumnIndex)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update product ?", "Questions", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                if (result == DialogResult.OK)
                {
                    int index = gvUpdate.CurrentCell.RowIndex;
                    employee user = (employee)gvUpdate.CurrentRow.DataBoundItem;
                    gvUpdate.DataSource = null;
                    employeeDL.updateEmployee(user);
                    employeeDL.addToFile();
                    employeeDL.LinkListToList();
                    gvUpdate.DataSource = employeeDL.employeeList;
                    gvUpdate.Refresh();

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashManager myForm = new dashManager();
            myForm.ShowDialog();
        }
    }
}
