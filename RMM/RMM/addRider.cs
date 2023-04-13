using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using RMM.BL;
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
    public partial class addRider : Form
    {
        public string name;
        public string cnic;
        public string email;
        public string contact;
        public string address;
        public addRider()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            cnic = txtCNIC.Text;
            contact = txtContact.Text;
            address = txtAddress.Text;
            email = txtMail.Text;
            if (name == "" || cnic == "" || email == "" || contact == "" || address == "")
            {
                MessageBox.Show("Sum of fields is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("Enter valid E-mail", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name.Contains("0") || name.Contains("1") || name.Contains("2") || name.Contains("3") || name.Contains("4") || name.Contains("5") || name.Contains("6") || name.Contains("7") || name.Contains("8") || name.Contains("9") || name.Contains("@") || name.Contains("$") || name.Contains("%") || name.Contains("&") || name.Contains("!") || name.Contains("*"))
            {
                MessageBox.Show("Enter valid name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cnic.Length < 13 || cnic.Length > 13)
            {
                MessageBox.Show("Enter valid CNIC", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (contact.Length < 11 || contact.Length > 11)
            {
                MessageBox.Show("Enter valid contact no", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rider obj = new rider(name,cnic+"cnic",email,contact+"contact",address);
                riderDL.insert_at_tail(obj);
                riderDL.LinkListToList();
                riderDL.addToFile();
                MessageBox.Show("Rider added successfully");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            riderForm myForm = new riderForm();
            myForm.ShowDialog();
        }
    }
}
