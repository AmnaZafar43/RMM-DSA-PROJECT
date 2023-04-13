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
    public partial class employeeDashboard : Form
    {
        public employeeDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderDetails myForm = new orderDetails();
            myForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            riderForm myForm = new riderForm();
            myForm.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login myform = new Login();
            myform.ShowDialog();
        }

        private void employeeDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            shopkeeperForm myForm = new shopkeeperForm();
            myForm.ShowDialog();
        }

        private void btnPL_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfitLoss myForm = new ProfitLoss();
            myForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report myForm = new Report();
            myForm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewStock myForm = new viewStock();
            myForm.ShowDialog();
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Routes myForm = new Routes();
            myForm.ShowDialog();
        }

        private void Riderbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            riderForm myForm = new riderForm();
            myForm.ShowDialog();
        }
    }
}
