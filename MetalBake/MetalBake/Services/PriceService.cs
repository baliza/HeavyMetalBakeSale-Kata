using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PriceService : IPriceable
    {
        private Dictionary<char, decimal> _itemsPrices = new Dictionary<char, decimal>
        {
            {'B', 0.65M },
            {'M', 1 },
            {'C', 1.35M },
            {'W', 1.5M }
        };

        public decimal GetItemPrice(char key)
        {
            return _itemsPrices[key];
        }

       
    }
}
