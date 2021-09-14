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

        public int GetItemStock(char key)
        {
            return _itemsStock[key];
        }

        public void ReduceItemStock(char key, int value)
        {
            _itemsStock[key] -= value;
        }
    }
}
