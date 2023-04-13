using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using RMM.BL;
using RMM.DL;

namespace RMM
{
    public partial class PlaceOrder : Form
    {
       float price;
        public PlaceOrder()
        {
            InitializeComponent();
            cmbName.DataSource = productDL.productList;
            cmbName.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RiderDashboard myForm = new RiderDashboard();
            myForm.ShowDialog();
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            product pro = cmbName.SelectedItem as product;
            txtPrice.Text = pro.Price.ToString();
            txtCategory.Text = pro.Category.ToString();
            txtBrand.Text = pro.Brand.ToString();
            string quant = txtQuantity.Text;
            //int prod = (int.Parse(txtQuantity.Text) * int.Parse(txtPrice.Text));
            //txtFinalPrice.Text = prod.ToString();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text=="") 
            {
                txtQuantity.Text = 0.ToString(); 
            }
            price = int.Parse(txtQuantity.Text) * float.Parse(txtPrice.Text);
            txtFinalPrice.Text = price.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string sName,brand,category,name;
            int quantity;
            float price,finalPrice;
            name = cmbName.Text;
            brand = txtBrand.Text;
            category = txtCategory.Text;
            quantity = int.Parse(txtQuantity.Text);
            price = float.Parse(txtPrice.Text);
            finalPrice = float.Parse(txtFinalPrice.Text);
            sName = txtShopName.Text;
            if(sName == "")
            {
                MessageBox.Show("Enter valid shopkeeper name");
            }
            placeOrderclass obj = new placeOrderclass(name,quantity,category,brand,price,sName,finalPrice);
            placeOrderDL.insert_at_tail(obj);
            placeOrderDL.LinkListToList();
            placeOrderDL.addToFile();
            MessageBox.Show("Order added successfully");
        }
    }
}
