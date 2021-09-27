using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBakeMVC.ViewModels
{
    public class ProductList
    {
        public Dictionary<string, int> stock;
        public Dictionary<string, decimal> prices;
    }
}