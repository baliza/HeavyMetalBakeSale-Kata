using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.library
{
    public class PriceService
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