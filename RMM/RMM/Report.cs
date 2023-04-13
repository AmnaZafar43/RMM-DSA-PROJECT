using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace RMM
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeDashboard myForm = new employeeDashboard();
            myForm.ShowDialog();
        }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }
          private void button1_Click(object sender, EventArgs e)
          {
              /* string path = @"C:\Users\toshiba\Documents\Semester 3\Data Structure and Algorithms\Final\FinalGit\cs261f22finalpid34\RMM\RMM\bin\Debug";
               string[] csvfiles = Directory.GetFiles(path, "*.csv", SearchOption.TopDirectoryOnly);
               using(var Reports=File.Create(path+"Reports.csv"))
               {
                    foreach(var csv in csvfiles)
                    {
                         using(var csvData=File.OpenRead(csv))
                         {
                              csvData.CopyTo(Reports);
                         }
                    }
               }*/

               if(dataGridView1.Rows.Count>0)
               {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "PDF (*.pdf)|*.pdf";
                    save.FileName = "Result.pdf";
                    bool errorMessage = false;
                    if(save.ShowDialog()==DialogResult.OK)
                    {
                         if(File.Exists(save.FileName))
                         {
                              try
                              {
                                   File.Delete(save.FileName);
                              }
                              catch(Exception ex)
                              {
                                   errorMessage = true;
                                   MessageBox.Show("Unable to write data in disk" + ex.Message);
                              }
                         }
                         if(!errorMessage)
                         {
                              try
                              {
                                   PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                                   pTable.DefaultCell.Padding = 2;
                                   pTable.WidthPercentage = 100;
                                   pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                   foreach(DataGridViewColumn col in dataGridView1.Columns)
                                   {
                                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                        pTable.AddCell(pCell);
                                   }
                                   foreach(DataGridViewRow viewRow in dataGridView1.Rows)
                                   {
                                        foreach(DataGridViewCell dcell in viewRow.Cells)
                                        {
                                             pTable.AddCell(dcell.Value.ToString());
                                        }
                                   }

                                   using (FileStream filestream=new FileStream(save.FileName, FileMode.Create))
                                   {
                                        Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                        document.Open();
                                        document.Add(pTable);
                                        document.Close();
                                        filestream.Close();
                                   }
                                   MessageBox.Show("Data Exported Successfully", "info");
                              }
                              catch(Exception ex)
                              {
                                   MessageBox.Show("Error while exporting data" + ex.Message);
                              }
                         }
                    }

               }
               else
               {
                    MessageBox.Show("No Record Found", "Info");
               }

          }

          private void button2_Click_1(object sender, EventArgs e)
          {

          }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            employeeDashboard myForm = new employeeDashboard();
            myForm.ShowDialog();
        }
          private void loadData1()
          {
               string delimeter = ",";
               string name = "Report";
               string fileName = ("C:\\Users\\toshiba\\Documents\\Semester 3\\Data Structure and Algorithms\\Final\\FinalGit\\cs261f22finalpid34\\RMM\\RMM\\bin\\Debug\\Rider.csv");

               DataSet dataset = new DataSet();
               StreamReader sr = new StreamReader(fileName);
               dataset.Tables.Add(name);
               dataset.Tables[name].Columns.Add("Name");
               dataset.Tables[name].Columns.Add("Contact");
               dataset.Tables[name].Columns.Add("CNIC");
               dataset.Tables[name].Columns.Add("Email");
               dataset.Tables[name].Columns.Add("Area");
               string alldata = sr.ReadToEnd();
               string[] rows = alldata.Split("\r".ToCharArray());
               foreach (string r in rows)
               {
                    string[] items = r.Split(delimeter.ToCharArray());
                    dataset.Tables[name].Rows.Add(items);
               }
               this.dataGridView1.DataSource = dataset.Tables[0].DefaultView;
          }
          private void btn_rider_Click(object sender, EventArgs e)
          {
               loadData1();
          }

          private void loadData2()
          {
               string delimeter = ",";
               string name = "Report";
               string fileName = ("C:\\Users\\toshiba\\Documents\\Semester 3\\Data Structure and Algorithms\\Final\\FinalGit\\cs261f22finalpid34\\RMM\\RMM\\bin\\Debug\\account.csv");

               DataSet dataset = new DataSet();
               StreamReader sr = new StreamReader(fileName);
               dataset.Tables.Add(name);
               dataset.Tables[name].Columns.Add("Email");
               dataset.Tables[name].Columns.Add("Rank");
               dataset.Tables[name].Columns.Add("Password");
               dataset.Tables[name].Columns.Add("Designation");
               //dataset.Tables[name].Columns.Add("Area");
               string alldata = sr.ReadToEnd();
               string[] rows = alldata.Split("\r".ToCharArray());
               foreach (string r in rows)
               {
                    string[] items = r.Split(delimeter.ToCharArray());
                    dataset.Tables[name].Rows.Add(items);
               }
               this.dataGridView1.DataSource = dataset.Tables[0].DefaultView;
          }

          private void btn_account_Click(object sender, EventArgs e)
          {
               loadData2();
          }
          private void loadData3()
          {
               string delimeter = ",";
               string name = "Report";
               string fileName = ("C:\\Users\\toshiba\\Documents\\Semester 3\\Data Structure and Algorithms\\Final\\FinalGit\\cs261f22finalpid34\\RMM\\RMM\\bin\\Debug\\Stock.csv");

               DataSet dataset = new DataSet();
               StreamReader sr = new StreamReader(fileName);
               dataset.Tables.Add(name);
               dataset.Tables[name].Columns.Add("Product Name");
               dataset.Tables[name].Columns.Add("Quantity");
               dataset.Tables[name].Columns.Add("Company");
               dataset.Tables[name].Columns.Add("Type");
               dataset.Tables[name].Columns.Add("Price");
               string alldata = sr.ReadToEnd();
               string[] rows = alldata.Split("\r".ToCharArray());
               foreach (string r in rows)
               {
                    string[] items = r.Split(delimeter.ToCharArray());
                    dataset.Tables[name].Rows.Add(items);
               }
               this.dataGridView1.DataSource = dataset.Tables[0].DefaultView;
          }

          private void btn_stock_Click(object sender, EventArgs e)
          {
               loadData3();
          }
          private void loadData4()
          {
               string delimeter = ",";
               string name = "Report";
               string fileName = ("C:\\Users\\toshiba\\Documents\\Semester 3\\Data Structure and Algorithms\\Final\\FinalGit\\cs261f22finalpid34\\RMM\\RMM\\bin\\Debug\\Employee.csv");

               DataSet dataset = new DataSet();
               StreamReader sr = new StreamReader(fileName);
               dataset.Tables.Add(name);
               dataset.Tables[name].Columns.Add("Name");
               dataset.Tables[name].Columns.Add("Age");
               dataset.Tables[name].Columns.Add("CNIC");
               dataset.Tables[name].Columns.Add("Contact");
               dataset.Tables[name].Columns.Add("Email");
               dataset.Tables[name].Columns.Add("Joining Date");
               string alldata = sr.ReadToEnd();
               string[] rows = alldata.Split("\r".ToCharArray());
               foreach (string r in rows)
               {
                    string[] items = r.Split(delimeter.ToCharArray());
                    dataset.Tables[name].Rows.Add(items);
               }
               this.dataGridView1.DataSource = dataset.Tables[0].DefaultView;
          }

          private void btn_employee_Click(object sender, EventArgs e)
          {
               loadData4();
          }
          private void loadData5()
          {
               string delimeter = ",";
               string name = "Report";
               string fileName = ("C:\\Users\\toshiba\\Documents\\Semester 3\\Data Structure and Algorithms\\Final\\FinalGit\\cs261f22finalpid34\\RMM\\RMM\\bin\\Debug\\Shopkeeper.csv");

               DataSet dataset = new DataSet();
               StreamReader sr = new StreamReader(fileName);
               dataset.Tables.Add(name);
               dataset.Tables[name].Columns.Add("Name");
               dataset.Tables[name].Columns.Add("Email");
               dataset.Tables[name].Columns.Add("CNIC");
               dataset.Tables[name].Columns.Add("Contact");
               dataset.Tables[name].Columns.Add("Landline");
               dataset.Tables[name].Columns.Add("Shop Name");
               string alldata = sr.ReadToEnd();
               string[] rows = alldata.Split("\r".ToCharArray());
               foreach (string r in rows)
               {
                    string[] items = r.Split(delimeter.ToCharArray());
                    dataset.Tables[name].Rows.Add(items);
               }
               this.dataGridView1.DataSource = dataset.Tables[0].DefaultView;
          }

          private void btn_shop_Click(object sender, EventArgs e)
          {
               loadData5();
          }
          private void loadData6()
          {
               string delimeter = ",";
               string name = "Report";
               string fileName = ("C:\\Users\\toshiba\\Documents\\Semester 3\\Data Structure and Algorithms\\Final\\FinalGit\\cs261f22finalpid34\\RMM\\RMM\\bin\\Debug\\OrderDetail.csv");

               DataSet dataset = new DataSet();
               StreamReader sr = new StreamReader(fileName);
               dataset.Tables.Add(name);
               dataset.Tables[name].Columns.Add("Product Name");
               dataset.Tables[name].Columns.Add("Quantity");
               dataset.Tables[name].Columns.Add("Product Type");
               dataset.Tables[name].Columns.Add("Company");
               dataset.Tables[name].Columns.Add("Price of One");
               dataset.Tables[name].Columns.Add("Customer Name");
               dataset.Tables[name].Columns.Add("Total");
               string alldata = sr.ReadToEnd();
               string[] rows = alldata.Split("\r".ToCharArray());
               foreach (string r in rows)
               {
                    string[] items = r.Split(delimeter.ToCharArray());
                    dataset.Tables[name].Rows.Add(items);
               }
               this.dataGridView1.DataSource = dataset.Tables[0].DefaultView;
          }

          private void btn_orderdetail_Click(object sender, EventArgs e)
          {
               loadData6();
          }
     }
}
