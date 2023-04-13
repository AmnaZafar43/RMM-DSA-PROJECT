using RMM.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMM.DL
{
    internal class placeOrderDL
    {
        static placeOrderclass head = null;
        public static List<placeOrderclass> orderList = new List<placeOrderclass>();

        public static void insert_at_head(placeOrderclass n)
        {
            n.Next = head;

            if (head != null)
            {
                head.Previous = n;
            }
            head = n;
        }
        public static void insert_at_tail(placeOrderclass n)
        {

            if (head == null)
            {
                insert_at_head(n);
                return;
            }
            placeOrderclass temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = n;
            n.Previous = temp;
        }
        public static bool addToFile()
        {
            string path = "OrderDetail.csv";
            using (StreamWriter accnt = new StreamWriter(path, false))
            {
                int i = 0;
                placeOrderclass temp = head;
                while (temp != null)
                {
                    i++;
                    accnt.WriteLine(temp.Name + "," + temp.Quantity + "," + temp.Category + "," + temp.Brand + "," + temp.Price + "," + temp.ShopkeeperName + "," + temp.FinalPrice);
                    temp = temp.Next;
                }
                accnt.Flush();
                accnt.Close();
            }
            return true;

        }
        public static bool getFromFile()
        {
            string path = "OrderDetail.csv";
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
                            int quantity = int.Parse(splittedRecord[1]);
                            string category = splittedRecord[2];
                            string brand = splittedRecord[3];
                            float price = float.Parse(splittedRecord[4]);
                            string shopkeeperName = splittedRecord[5];
                            float finalPrice = float.Parse(splittedRecord[6]);
                            placeOrderclass obj = new placeOrderclass(name,quantity,category,brand,price,shopkeeperName,finalPrice);
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
            placeOrderclass temp = head;
            orderList.Clear();
            while (temp != null)
            {
                addToList(temp);
                temp = temp.Next;
            }
            return true;
        }
        public static void addToList(placeOrderclass obj)
        {
            orderList.Add(obj);
        }
        public static bool deleteOrder(placeOrderclass pro) // delete a node
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

            placeOrderclass current = head;
            int i;

            for (i = 1; current != null && i < n; i++)
            {
                current = current.Next;
            }

            if (current == null)
                return;
            deleteOrder(current);
        }
        public static bool updateOrder(placeOrderclass data)
        {
            placeOrderclass pro = head;
            while (pro != null)
            {
                if (pro.Name == data.Name)
                {

                    pro.Name = data.Name;
                    pro.Quantity = data.Quantity;
                    pro.Category = data.Category;
                    pro.Brand = data.Brand;
                    pro.Price = data.Price;
                    pro.ShopkeeperName = data.ShopkeeperName;
                    pro.FinalPrice = data.FinalPrice;
                }
                pro = pro.Next;
            }
            return true;
        }
    }
}
