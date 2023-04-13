using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMM.BL;

namespace RMM.DL
{
    internal class shopkeeperDL
    {
          static shopkeeper head = null;
          public static List<shopkeeper> shopkeeperList = new List<shopkeeper>();
          public static void insert_at_head(shopkeeper n)
          {
               n.Next = head;

               if (head != null)
               {
                    head.Previous = n;
               }
               head = n;
          }
          public static void insert_at_tail(shopkeeper n)
          {

               if (head == null)
               {
                    insert_at_head(n);
                    return;
               }
               shopkeeper temp = head;
               while (temp.Next != null)
               {
                    temp = temp.Next;
               }
               temp.Next = n;
               n.Previous = temp;
          }
        public static bool addToFile()
        {
            string path = "Shopkeeper.csv";
            using (StreamWriter accnt = new StreamWriter(path, false))
            {
                int i = 0;
                shopkeeper temp = head;
                while (temp != null)
                {
                    i++;
                    accnt.WriteLine(temp.Name + "," + temp.Email + "," + temp.Cnic + "," + temp.Contact + "," + temp.Landline + "," + temp.ShopName);
                    temp = temp.Next;
                }
                accnt.Flush();
                accnt.Close();
            }
            return true;

        }

        public static bool getFromFile()
        {
            string path = "Shopkeeper.csv";
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
                            string email = splittedRecord[1];
                            string cnic = splittedRecord[2];
                            string contact = splittedRecord[3];
                            string landline = splittedRecord[4];
                            string shopName = splittedRecord[5];
                            shopkeeper obj = new shopkeeper(shopName,landline,name,email,cnic,contact);
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
               shopkeeper temp = head;
               shopkeeperList.Clear();
               while (temp != null)
               {
                    addToList(temp);
                    temp = temp.Next;
               }
               return true;
          }
          public static void addToList(shopkeeper obj)
          {
               shopkeeperList.Add(obj);
          }
        public static bool deleteProduct(shopkeeper pro) // delete a node
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

            shopkeeper current = head;
            int i;

            for (i = 1; current != null && i < n; i++)
            {
                current = current.Next;
            }

            if (current == null)
                return;
            deleteProduct(current);
        }
        public static bool updateProduct(shopkeeper data)
        {
            shopkeeper pro = head;
            while (pro != null)
            {
                if (pro.Name == data.Name)
                {

                    pro.Name = data.Name;
                    pro.Email = data.Email;
                    pro.Contact = data.Contact;
                    pro.Cnic = data.Cnic;
                    pro.ShopName = data.ShopName;
                    pro.Landline = data.Landline;
                }
                pro = pro.Next;
            }
            return true;
        }
    }
}
