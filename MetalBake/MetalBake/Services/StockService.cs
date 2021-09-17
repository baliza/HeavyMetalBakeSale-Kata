using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class StockService : IStockService
    {
        private Dictionary<char, decimal> productStock = new Dictionary<char, decimal>
        {
            {'B', 40 },
            {'M', 36},
            {'C', 24 },
            {'W', 30 }
        };
    }
}
