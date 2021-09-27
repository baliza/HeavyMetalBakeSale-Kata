using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBakeMVCFront.Models
{
    public class ItemIndex
    {
        public string ItemId { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}