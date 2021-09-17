using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PriceService
    {
        private Dictionary<char, decimal> productPrice = new Dictionary<char, decimal>
        {
            {'B', 0.65M },
            {'M', 1M},
            {'C', 1.35M },
            {'W', 1.50M }
        };
    }
}
