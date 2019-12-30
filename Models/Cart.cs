using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EshopServerApi.Models
{
    public class Cart
    {
        public int id { get; set; }
        public string productSku { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
        public string currency { get; set; }
    }
}