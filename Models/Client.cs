using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopServerApi.Models
{
    public class Client
    {
        public int id { get; set; }
        public string completeName { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public Order Order { get; set; }
    }
}