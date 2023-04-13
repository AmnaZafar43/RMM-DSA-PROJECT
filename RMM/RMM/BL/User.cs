using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMM.BL
{
    internal class User
    {
        private string emailAddress;
        private string name;
        private string id;
        private string address;
        private string cnicNo;
        private string contact;
        public User()
        {

        }
         public User(string emailAddress, string name, string id, string address, string cnicNo, string contact)
        {
            this.emailAddress = emailAddress;
            this.name = name;
            this.id = id;
            this.address = address;
            this.cnicNo = cnicNo;
            this.contact = contact;
        }


        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Address { get => address; set => address = value; }
        public string CnicNo { get => cnicNo; set => cnicNo = value; }
        public string Contact { get => contact; set => contact = value; }
    }
}
