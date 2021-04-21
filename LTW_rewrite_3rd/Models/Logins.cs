using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTW_rewrite_3rd.Models
{
    class Logins
    {
        private string username;
        private string password;

        public Logins() { }
        public Logins(string user, string pass)
        {
            this.username = user;
            this.password = pass;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
