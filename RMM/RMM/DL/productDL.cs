using RMM.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace RMM.DL
{
    internal class productDL
    {
        static product head = null;
        public static List<product> productList = new List<product>();

        public static void insert_at_head(product n)
        {
            n.Next = head;

            if (head != null)
            {
                head.Previous = n;
            }
            head = n;
        }
        public static void insert_at_tail(product n)
        {

            if (head == null)
            {
                insert_at_head(n);
                return;
            }
            product temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = n;
            n.Previous = temp;
        }
        public static bool addToFile()
        {
            string path = "Stock.csv";
            using (StreamWriter accnt = new StreamWriter(path,false))
            {
                int i = 0;
                product temp = head;
                while (temp != null)
                {
                    i++;
                    accnt.WriteLine(temp.Name + "," + temp.Price+ "," + temp.Brand + "," + temp.Category+ "," + temp.Description + "," + temp.Quantity + "," + temp.Weight);
                    temp = temp.Next;
                }
                accnt.Flush();
                accnt.Close();
            }
            return true;
       
        }

        public static bool getFromFile()
        {
            string path = "Stock.csv";
            if (System.IO.File.Exists(path))
            {
                try
                {
                    using (StreamReader file = new StreamReader(path))
                    while (!file.EndOfStream)
                    {
                        string record = file.ReadLine();
                        string[] splittedRecord = record.Split(',');
                        string name = splittedRecord[0];
                        float price = float.Parse(splittedRecord[1]);
                        string brand = splittedRecord[2];
                        string category = splittedRecord[3];
                        string description = splittedRecord[4];
                        int quantity = int.Parse(splittedRecord[5]);
                        double weight = double.Parse(splittedRecord[6]);
                        product obj = new product(category,name,quantity,price,description,weight,brand);
                        insert_at_tail(obj);
                        LinkListToList();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            return false;
        }
        public static bool LinkListToList()
        {
            product temp = head;
            productList.Clear();
            while(temp != null)
            {
                addToList(temp);
                temp = temp.Next;
            }
            return true;
        }
        public static void addToList(product obj)
        {
            productList.Add(obj);
        }
        public static bool deleteProduct(product pro) // delete a node
        {
            if (head == null || pro == null)
            {
                return false;
            }

            if (head == pro)
            {
                head = pro.Next;
            }

            if (pro.Next != null)
            {
                pro.Next.Previous = pro.Previous;
            }

            if (pro.Previous != null)
            {
                pro.Previous.Next = pro.Next;
            }
            return true;
        }
        public static void deleteNodeAtGivenPos(int n) // delete a specific position
        {
            if (head == null || n <= 0)
                return;

            product current = head;
            int i;

            for (i = 1; current != null && i < n; i++)
            {
                current = current.Next;
            }

            if (current == null)
                return;
            deleteProduct(current);
        }
        public static bool updateProduct(product data)
        {
            product pro = head;
            while (pro != null)
            {
                if (pro.Name == data.Name)
                {

                    pro.Name = data.Name;
                    pro.Price = data.Price;
                    pro.Category = data.Category;
                    pro.Brand = data.Brand;
                    pro.Weight = data.Weight;
                    pro.Description = data.Description;
                    pro.Quantity = data.Quantity;
                }
                pro = pro.Next;
            }
            return true;
        }

    }
}
