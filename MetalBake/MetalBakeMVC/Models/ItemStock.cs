using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBakeMVC.Models
{
    public class ItemStock
    {
        public string ItemId { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
    }
}