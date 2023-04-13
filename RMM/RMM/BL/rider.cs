using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMM.BL
{
    internal class rider
    {
        private string name;
        private string cnic;
        private string emailAddress;
        private string contact;
        private string address;
        private rider next;
        private rider previous;

        public rider(string name, string cnic, string emailAddress, string contact, string address)
        {
            this.name = name;
            this.cnic = cnic;
            this.emailAddress = emailAddress;
            this.contact = contact;
            this.address = address;
        }

        public string Name { get => name; set => name = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Address { get => address; set => address = value; }
        internal rider Next { get => next; set => next = value; }
        internal rider Previous { get => previous; set => previous = value; }
    }
}
