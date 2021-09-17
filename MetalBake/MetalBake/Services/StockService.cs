using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class StockService : IStockService
    {
        private Dictionary<string, int> productStock = new Dictionary<string, int>
                {
                    {"B", 40 },
                    {"M", 36},
                    {"C", 24 },
                    {"W", 30 }
                };
        public int ProductStock(string id)
        {
            return productStock[id];
        }
        public void CompareStock(string id)
        {
            if (productStock[id] <= 0)
            {
                Console.WriteLine("Not stock");
            }
             
        }
        public void ReducedStock(string id)
        {
            productStock[id]--;
        }
    }
}
