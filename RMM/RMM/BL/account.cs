using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMM.BL
{
    internal class account
    {
        private string email;
        private string password;
        private string username;
        private string role;
        public account(string email, string password, string username, string role)
        {
            this.email = email;
            this.password = password;
            this.username = username;
            this.role = role;
        }
        public account(string email,string password)
        {
            this.email = email;
            this.password = password;
        }

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public string Role { get => role; set => role = value; }
    }
}
