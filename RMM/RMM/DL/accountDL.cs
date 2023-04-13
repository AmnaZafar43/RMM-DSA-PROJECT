using RMM.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMM.DL
{
    internal class accountDL
    {
        public static List<account> accountList = new List<account>();
        public static void addInList(account obj)
        {
            accountList.Add(obj);
        }
        public static bool addToFile()
        {
            string path = "account.csv";
            using (StreamWriter accnt = new StreamWriter(path,true))
            {
                foreach (account a in accountList)
                {
                    var row = string.Format("{0},{1},{2},{3}", a.Email, a.Username, a.Password, a.Role);
                    accnt.WriteLine(row);
                }
                accnt.Flush();
            }
            return true;

        }
        public static bool getFromFile()
        {
            string path = "account.csv";
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                    while (!file.EndOfStream)
                    {
                        string record = file.ReadLine();
                        string[] splittedRecord = record.Split(',');
                        string email = splittedRecord[0];
                        string username = splittedRecord[1];
                        string password = splittedRecord[2];
                        string role = splittedRecord[3];
                        account accnt = new account(email, password, username, role);
                        addInList(accnt);
                        Console.WriteLine(accnt.Email,accnt.Username,accnt.Password,accnt.Role);
                    }
                return true;
            }
            return false;
        }
        public static account checkRole(account accnt)
        {
            foreach(account a in accountList)
            {
                if(accnt.Password == a.Password && accnt.Email == a.Email)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
