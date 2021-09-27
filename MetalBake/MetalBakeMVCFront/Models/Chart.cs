using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBakeMVCFront.Models
{
    public class Chart
    {
        public List<ItemOrder> Order { get; set; }
        public decimal ChartPrice { get; set; }
    }
}