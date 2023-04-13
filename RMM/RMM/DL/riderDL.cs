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
    internal class riderDL
    {
        static rider head = null;
        public static List<rider> riderList = new List<rider>();

        public static void insert_at_head(rider n)
        {
            n.Next = head;

            if (head != null)
            {
                head.Previous = n;
            }
            head = n;
        }
        public static void insert_at_tail(rider n)
        {

            if (head == null)
            {
                insert_at_head(n);
                return;
            }
            rider temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = n;
            n.Previous = temp;
        }
        public static bool addToFile()
        {
            string path = "Rider.csv";
            using (StreamWriter accnt = new StreamWriter(path, false))
            {
                int i = 0;
                rider temp = head;
                while (temp != null)
                {
                    i++;
                    accnt.WriteLine(temp.Name + "," + temp.Cnic + "," + temp.Contact + "," + temp.EmailAddress + "," + temp.Address);
                    temp = temp.Next;
                }
                accnt.Flush();
                accnt.Close();
            }
            return true;

        }
        public static bool getFromFile()
        {
            string path = "Rider.csv";
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
                            string cnic = splittedRecord[1];
                            string contact = splittedRecord[2];
                            string email = splittedRecord[3];
                            string address = splittedRecord[4];
                            rider obj = new rider(name,cnic,email,contact,address);
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
            rider temp = head;
            riderList.Clear();
            while (temp != null)
            {
                addToList(temp);
                temp = temp.Next;
            }
            return true;
        }
        public static void addToList(rider obj)
        {
            riderList.Add(obj);
        }
        public static bool deleteProduct(rider pro) // delete a node
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

            rider current = head;
            int i;

            for (i = 1; current != null && i < n; i++)
            {
                current = current.Next;
            }

            if (current == null)
                return;
            deleteProduct(current);
        }
        public static bool updateProduct(rider data)
        {
            rider pro = head;
            while (pro != null)
            {
                if (pro.Name == data.Name)
                {

                    pro.Name = data.Name;
                    pro.Address = data.Address;
                    pro.EmailAddress = data.EmailAddress;
                    pro.Cnic = data.Cnic;
                    pro.Address = data.Address;
                }
                pro = pro.Next;
            }
            return true;
        }
    }
}
