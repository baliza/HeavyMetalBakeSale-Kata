using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class StockService : IStockable
    {
        private Dictionary<char, int> _itemsStock = new Dictionary<char, int>
        {
            {'B', 40 },
            {'M', 36},
            {'C', 24 },
            {'W', 30 }
        };

      

        public void CheckItemStock(char key)
        {
            if(_itemsStock[key] <= 0)
            {
                throw new Exception("Not enought stock");
            }
        }
        public void ReduceItemStock(char key)
        {
            _itemsStock[key] -= 1;
        }
    }
}
