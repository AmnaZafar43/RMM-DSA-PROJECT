using RMM.BL;
using RMM.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RMM
{
    public partial class Login : Form
    {
        public string mailtxt;
        public string passtxt;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passbox.UseSystemPasswordChar = true;
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
           mailtxt = emailBox.Text;
           passtxt = passbox.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passbox.UseSystemPasswordChar = false;
            }
            else
            {
                passbox.UseSystemPasswordChar = true;
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            mailtxt = emailBox.Text;
            passtxt = passbox.Text;
            if (mailtxt == "" || passtxt == "")
            {
                MessageBox.Show("Sum of fields is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!mailtxt.Contains("@") || !mailtxt.Contains(".com"))
            {
                MessageBox.Show("Enter valid E-mail", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passtxt.Length < 8)
            {
                MessageBox.Show("Password must be 8 characters long", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                account accnt = null;
                accountDL.getFromFile();
                account obj = new account(mailtxt, passtxt);
                accnt = accountDL.checkRole(obj);
                if(accnt == null)
                {
                    MessageBox.Show("Enter valid credentials", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(accnt.Role == "Manager")
                    {
                        this.Hide();
                        dashManager myForm = new dashManager();
                        myForm.ShowDialog();
                    }
                    else if(accnt.Role == "Employee")
                    {
                        this.Hide();
                        employeeDashboard myform = new employeeDashboard();
                        myform.ShowDialog();
                    }
                    else if(accnt.Role == "Rider")
                    {
                        this.Hide();
                        RiderDashboard myform = new RiderDashboard();
                        myform.ShowDialog();
                    }
                }
            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUp myForm = new signUp();
            myForm.ShowDialog();
        }
    }
}
