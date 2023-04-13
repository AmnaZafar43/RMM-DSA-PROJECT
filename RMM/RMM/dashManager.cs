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
    public partial class dashManager : Form
    {
        public dashManager()
        {
            InitializeComponent();

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login myForm = new Login();
            myForm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewStock myForm = new viewStock();
            myForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report myForm = new Report();
            myForm.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            addEmployee myFrom = new addEmployee();
            myFrom.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteEmployee myForm = new deleteEmployee();
            myForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateEmployee myForm = new updateEmployee();
            myForm.ShowDialog();
        }

        private void btnPL_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfitLoss myForm = new ProfitLoss();
            myForm.ShowDialog();
        }
    }
}
