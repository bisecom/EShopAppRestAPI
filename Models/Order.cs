using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopServerApi.Models
{
    public class Order
    {
        public int id { get; set; }
        public DateTime orderTime { get; set; }
        public string clientEmail { get; set; }
        public string productSku { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
    }
}