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
    public partial class assignRoutes : Form
    {
        public assignRoutes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Routes myForm = new Routes();
            myForm.ShowDialog();
        }

          private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
          {

          }

          private void search_data_Click(object sender, EventArgs e)
          {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Routes myForm = new Routes();
            myForm.ShowDialog();
        }
    }
}
