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
    public partial class Routes : Form
    {
        public Routes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeDashboard myForm = new employeeDashboard();
            myForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            assignRoutes myForm = new assignRoutes();
            myForm.ShowDialog();

        }

          private void label2_Click(object sender, EventArgs e)
          {

          }

          private void label4_Click(object sender, EventArgs e)
          {

          }

          private void search_data_Click(object sender, EventArgs e)
          {
               string street = txt_street.Text;
               string city = txt_city.Text;
               string state = txt_state.Text;
               string zip = txt_zip.Text;
               try
               {
                    StringBuilder queryAddress = new StringBuilder();
                    queryAddress.Append("http://maps.google.com/maps?q=");

                    if(street!=String.Empty)
                    {
                         queryAddress.Append(street + "," + "+");
                    }
                    if (city != String.Empty)
                    {
                         queryAddress.Append(city + "," + "+");
                    }
                    if (state != String.Empty)
                    {
                         queryAddress.Append(state + "," + "+");
                    }
                    if (zip != String.Empty)
                    {
                         queryAddress.Append(zip + "," + "+");
                    }

                    webBrowser1.Navigate(queryAddress.ToString());
               }
               catch(Exception ex)
               {
                    MessageBox.Show(ex.Message.ToString(), "Error");
               }
          }

          private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
          {

          }
     }
}
