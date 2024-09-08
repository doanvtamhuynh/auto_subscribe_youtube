using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_subscribe_youtube.Model
{
    internal class EmailAccount
    {
        public string email {  get; set; }
        public string password { get; set; }

        public EmailAccount() { }
        public EmailAccount(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}
