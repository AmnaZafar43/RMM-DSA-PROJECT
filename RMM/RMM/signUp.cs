using RMM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMM
{
    public partial class signUp : Form
    {
        public string mail;
        public string pass;
        public string name;
        public string category;
        public signUp()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            passbox.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            mail = emailBox.Text;
            pass = passbox.Text;
            name = username.Text;
            category = combo1.Text;
            if (mail == "" || pass == "" || name == "")
            {
                MessageBox.Show("Sum of fields is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!mail.Contains("@") || !mail.Contains(".com"))
            {
                MessageBox.Show("Enter valid E-mail", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(pass.Length < 8)
            {
                MessageBox.Show("Password must be 8 characters long", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                account obj = new account(mail, pass, name, category);
                DL.accountDL.addInList(obj);
                DL.accountDL.addToFile();
                MessageBox.Show("Added successfully");
            }
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
    }
}
