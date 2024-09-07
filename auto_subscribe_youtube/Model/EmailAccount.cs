using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_subscribe_youtube.Model
{
    internal class EmailAccount
    {
        private string email {  get; set; }
        private string password { get; set; }
        private string recovery { get; set; }

        public EmailAccount() { }
        public EmailAccount(string email, string password, string recovery)
        {
            this.email = email;
            this.password = password;
            this.recovery = recovery;
        }
    }
}
