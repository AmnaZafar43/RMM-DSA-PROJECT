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
    public partial class addShopkeeper : Form
    {
          public string name;
          public string email;
          public string id;
          public string contact;
          public string shopName;
          public string address;
          public string area;
          public string landline;
          public string cnic;
          public addShopkeeper()
        {
            InitializeComponent();
        }

        private void addShopkeeper_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            RiderDashboard myForm = new RiderDashboard();
            myForm.ShowDialog();

        }

          private void btnAdd_Click_1(object sender, EventArgs e)
          {
               string name;
               string email;
               string cnic;
               string shopName;
               string area;
               string landline;
               string contact;
               name = txtName.Text;
               email = txtEmail.Text;
               cnic = txtCNIC.Text;
               shopName = txtShop.Text;
               area = txt_street.Text;
               landline = txtLandline.Text;
               contact = txtcontact.Text;
               if (name == ""|| email == "" || contact == "" || cnic == ""|| area  == "" || landline == "" || shopName == "")
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
               else if (landline.Length < 10 || landline.Length > 10)
               {
                    MessageBox.Show("Enter valid landline no", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               else
               {
                    BL.shopkeeper skeeper = new BL.shopkeeper(shopName, landline, name, email, cnic, contact);
                    shopkeeperDL.insert_at_tail(skeeper);
                    shopkeeperDL.LinkListToList();
                    shopkeeperDL.addToFile();
                    MessageBox.Show("Shopkeeper added successfully");
                    
               }
          }

          private void panel1_Paint(object sender, PaintEventArgs e)
          {

          }

          private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
          {

          }

          private void label12_Click(object sender, EventArgs e)
          {
               
          }

          private void button1_Click(object sender, EventArgs e)
          {
               string street = txt_street.Text;
               string city = txt_city.Text;
               string area = txt_street.Text;
               try
               {
                    StringBuilder queryAddress = new StringBuilder();
                    queryAddress.Append("http://maps.google.com/maps?q=");

                    if (street != String.Empty)
                    {
                         queryAddress.Append(street + "," + "+");
                    }
                    if (city != String.Empty)
                    {
                         queryAddress.Append(city + "," + "+");
                    }
                    if (area != String.Empty)
                    {
                         queryAddress.Append(area + "," + "+");
                    }

                    webBrowser1.Navigate(queryAddress.ToString());
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message.ToString(), "Error");
               }
          }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RiderDashboard myForm = new RiderDashboard();
            myForm.ShowDialog();
        }
    }
}
