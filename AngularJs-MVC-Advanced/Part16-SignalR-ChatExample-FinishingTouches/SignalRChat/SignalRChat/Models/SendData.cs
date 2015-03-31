using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRChat.Models
{
    public class SendData
    {
        public string message { get; set; }
        public string roomName { get; set; }
        public string name { get; set; }
    }
}