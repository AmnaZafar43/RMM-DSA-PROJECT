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
    public partial class addEmployee : Form
    {
        public string name;
        public string cnic;
        public int age;
        public string email;
        public string contact;
        public string agecheck;
        public string date;
        public addEmployee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            agecheck = txtAge.Text;
            name = txtName.Text;
            cnic = txtCNIC.Text;
            if (agecheck.Length > 0)
            {
                age = int.Parse(txtAge.Text);
            }
            email = txtMail.Text;
            contact = txtContact.Text;
            date = txtDate.Text;
            if (name == "" || cnic == "" || age <= 0 || email == "" || contact == "")
            {
                MessageBox.Show("Sum of fields is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("Enter valid E-mail", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (age <= 0 || agecheck.Length == 0)
            {
                MessageBox.Show("Enter valid age", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                employee obj = new employee(name, age, cnic+"cnic", email, contact+"contact", date);
                DL.employeeDL.insert_at_tail(obj);
                DL.employeeDL.employeeList.Add(obj);
                DL.employeeDL.addToFile();
                MessageBox.Show("Added successfully");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_Load(object sender, EventArgs e)
        {

        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
