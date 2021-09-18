using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PriceService
    {
        private Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>
        {
            {"B", 0.65M },
            {"M", 1M},
            {"C", 1.35M },
            {"W", 1.50M }
        };
        public decimal ProductPrice(string id)
        {
            return productPrice[id];
        }
    }
}
