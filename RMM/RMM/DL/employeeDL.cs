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
    internal class employeeDL
    {
        static employee head = null;
        public static List<employee> employeeList = new List<employee>();


        public static void insert_at_head(employee n)
        {
            n.Next = head;

            if (head != null)
            {
                head.Previous = n;
            }
            head = n;
        }
        public static void insert_at_tail(employee n)
        {

            if (head == null)
            {
                insert_at_head(n);
                return;
            }
            employee temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = n;
            n.Previous = temp;
        }
        public static bool addToFile()
        {
            string path = "Employee.csv";
            using (StreamWriter accnt = new StreamWriter(path, false))
            {
                int i = 0;
                employee temp = head;
                while (temp != null)
                {
                    i++;
                    accnt.WriteLine(temp.Name + "," + temp.Age + "," + temp.Cnic + "," + temp.Contact + "," + temp.Email + "," + temp.JoinDate);
                    temp = temp.Next;
                }
                accnt.Flush();
                accnt.Close();
            }
            return true;

        }
        public static bool getFromFile()
        {
            string path = "Employee.csv";
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
                            int age = int.Parse(splittedRecord[1]);
                            string cnic = splittedRecord[2];
                            string contact = splittedRecord[3];
                            string email = splittedRecord[4];
                            string joinDate = splittedRecord[5];
                            employee obj = new employee(name,age,cnic,email,contact,joinDate);
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
            employee temp = head;
            employeeList.Clear();
            while (temp != null)
            {
                addToList(temp);
                temp = temp.Next;
            }
            return true;
        }
        public static void addToList(employee obj)
        {
            employeeList.Add(obj);
        }
        public static bool deleteEmployee(employee pro) // delete a node
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

            employee current = head;
            int i;

            for (i = 1; current != null && i < n; i++)
            {
                current = current.Next;
            }

            if (current == null)
                return;
            deleteEmployee(current);
        }
        public static bool updateEmployee(employee data)
        {
            employee pro = head;
            while (pro != null)
            {
                if (pro.Name == data.Name)
                {

                    pro.Name = data.Name;
                    pro.Contact = data.Contact;
                    pro.Cnic = data.Cnic;
                    pro.Email = data.Email;
                    pro.Age = data.Age;
                    pro.JoinDate = data.JoinDate;
                }
                pro = pro.Next;
            }
            return true;
        }
    }
}
