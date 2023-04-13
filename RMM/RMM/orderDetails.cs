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
    public partial class orderDetails : Form
    {
        public orderDetails()
        {
            InitializeComponent();
            gvView.DataSource = DL.placeOrderDL.orderList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeDashboard myForm = new employeeDashboard();
            myForm.ShowDialog();
        }

        private void orderDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
