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
    public partial class E_mail : Form
    {
        public E_mail()
        {
            InitializeComponent();
        }

        private void E_mail_Load(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            RiderDashboard myForm = new RiderDashboard();
            myForm.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            string body = txtBody.Text;
            BL.email.SendMail(mail, body);
        }
    }
}
