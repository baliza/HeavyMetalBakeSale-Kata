using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBakeMVC.Models
{
    public class Product
    {
        public string id { get; set; }
        public int stock { get; set; }
        public decimal price { get; set; }
    }
}