using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class riderForm : Form
    {
        public riderForm()
        {
            InitializeComponent();
            gvViewRider.DataSource = DL.riderDL.riderList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeDashboard myForm = new employeeDashboard();
            myForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteRider myForm = new deleteRider();
            myForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateRider myForm = new updateRider();
            myForm.ShowDialog();
        }

        private void riderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            addRider myForm = new addRider();
            myForm.ShowDialog();
        }
    }
}
