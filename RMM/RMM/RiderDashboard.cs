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
    public partial class RiderDashboard : Form
    {
        public RiderDashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            addShopkeeper myForm = new addShopkeeper();
            myForm.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlaceOrder myForm = new PlaceOrder();
            myForm.ShowDialog();
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            Routes myForm = new Routes();
            myForm.ShowDialog();
        }

        private void btnOD_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderDetails myForm = new orderDetails();
            myForm.ShowDialog();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login myForm = new Login();
            myForm.ShowDialog();
        }

          private void panel1_Paint(object sender, PaintEventArgs e)
          {

          }
     }
}
