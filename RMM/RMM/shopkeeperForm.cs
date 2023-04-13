using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class shopkeeperForm : Form
    {
        public shopkeeperForm()
        {
            InitializeComponent();
            gvView.DataSource = shopkeeperDL.shopkeeperList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeDashboard myForm = new employeeDashboard();
            myForm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteShopkeeper myForm = new deleteShopkeeper();
            myForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateShopkeeper myForm = new updateShopkeeper();
            myForm.ShowDialog();
        }

        private void shopkeeperForm_Load(object sender, EventArgs e)
        {

        }
    }
}
