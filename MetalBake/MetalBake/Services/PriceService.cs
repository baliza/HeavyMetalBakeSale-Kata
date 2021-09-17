using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PriceService : IPriceService
    {
        private Dictionary<string, decimal> _itemsPrices = new Dictionary<string, decimal>
        {
            {"B", 0.65M },
            {"M", 1 },
            {"C", 1.35M },
            {"W", 1.5M }
        };

        public decimal GetItemPrice(string itemId)
        {
            return _itemsPrices[itemId];
        }
    }
}