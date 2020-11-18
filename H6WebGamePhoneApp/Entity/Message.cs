using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGamePhoneApp.Entity
{
    public class Message
    {
        public int MessageID { get; set; }
        public string UserID { get; set; }
        public string MessageContent { get; set; }
        public DateTime DateTime { get; set; }
    }
}
