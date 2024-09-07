using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_subscribe_youtube.Model
{
    internal class Youtube
    {
        public string channel {  get; set; }
        public string link { get; set; }

        public Youtube() { }

        public Youtube(string channel, string link)
        {
            this.channel = channel;
            this.link = link;
        }
    }
}
