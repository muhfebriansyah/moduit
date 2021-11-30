using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace moduit.Models
{
    public class Items
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string footer { get; set; }
        public string createdAt { get; set; }
    }
}