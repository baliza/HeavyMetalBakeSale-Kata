using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBakeMVCFront.Models
{
    public class Cart
    {
        public List<ItemOrder> Order { get; set; }
        public decimal CartPrice { get; set; }
    }
}