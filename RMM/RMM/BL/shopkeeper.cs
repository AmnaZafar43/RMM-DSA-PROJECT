using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RMM.BL
{
    class shopkeeper 
    {
        private string shopName;
        private string landline;
        private string name;
        private string email;
        private string cnic;
        private string contact;
        private shopkeeper next;
        private shopkeeper previous;
        public shopkeeper(string shopName, string landline,string name, string email, string cnic, string contact)
        {
            this.shopName = shopName;
            this.landline = landline;
            this.name = name;
            this.email = email;
            this.cnic = cnic;
            this.contact = contact;
               
          }
        public string ShopName { get => shopName; set => shopName = value; }
        public string Landline { get => landline; set => landline = value; }
          public string Name { get => name; set => name = value; }
          public string Email { get => email; set => email = value; }
          public string Cnic { get => cnic; set => cnic = value; }
          public string Contact { get => contact; set => contact = value; }
        internal shopkeeper Next { get => next; set => next = value; }
        internal shopkeeper Previous { get => previous; set => previous = value; }
    }
}
