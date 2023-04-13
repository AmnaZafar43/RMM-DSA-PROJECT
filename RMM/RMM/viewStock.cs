using RMM.BL;
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
    public partial class viewStock : Form
    {
        public viewStock()
        {
            InitializeComponent();
            gvView.DataSource = DL.productDL.productList;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStock myForm = new AddStock();
            myForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteStock myForm = new deleteStock();
            myForm.ShowDialog();
        }

        private void viewStock_Load(object sender, EventArgs e)
        {
            Console.WriteLine(DL.productDL.productList.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateStock myForm = new updateStock();
            myForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeDashboard myForm = new employeeDashboard();
            myForm.ShowDialog();
        }
        private void dataBind()
        {
            gvView.DataSource = null;
            gvView.DataSource = DL.productDL.productList;
            gvView.Refresh();
        }
    }
}
