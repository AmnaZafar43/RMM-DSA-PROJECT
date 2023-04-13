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
    public partial class AddStock : Form
    {
        public string name;
        public int quantity;
        public string category;
        public string stock;
        public int price;
        public string brand;
        public float weight;
        public string description;
        public string quantityCheck;
        public string priceCheck;
        public string weightCheck; 
        public AddStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewStock myForm = new viewStock();
            myForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            quantityCheck = txtQuantity.Text;
            if(quantityCheck.Length > 0)
            {
                quantity = int.Parse(txtQuantity.Text);
            }
            priceCheck = txtPrice.Text;
            if(priceCheck.Length > 0)
            {
                price = int.Parse(txtPrice.Text);
            }
            weightCheck = txtWeight.Text;
            if(weightCheck.Length > 0)
            {
                weight = int.Parse(txtWeight.Text);
            }
            name = txtname.Text;
            category = txtCategory.Text;
            brand = txtBrand.Text;
            description = txtDesc.Text;
            if(name =="" || category == "" || brand == "" || description == "")
            {
                MessageBox.Show("Sum of fields is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(quantity<=0 || quantityCheck.Length == 0)
            {
                MessageBox.Show("Enter quantity greater than 0", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(price<=0 || priceCheck.Length == 0)
            {
                MessageBox.Show("Enter price greater than 0", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(weight<=0 || weightCheck.Length ==0)
            {
                MessageBox.Show("Enter weight greater than 0", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(name.Contains("@") || name.Contains("&") || name.Contains("!") || name.Contains("%") || name.Contains(".") || name.Contains("-") || name.Contains("*") || name.Contains("+") || name.Contains("#") || name.Contains("^"))
            {
                MessageBox.Show("Enter valid name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                product obj = new product(category, name, quantity, price, description, weight, brand);
                productDL.insert_at_tail(obj);
                productDL.LinkListToList();
                productDL.addToFile();
                MessageBox.Show("Product added successfully");
            }

        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStock_Load(object sender, EventArgs e)
        {

        }
    }
}
