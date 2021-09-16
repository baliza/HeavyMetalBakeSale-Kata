using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class StockService : IStockService
    {
        private Dictionary<char, int> _itemsStock = new Dictionary<char, int>
        {
            {'B', 40 },
            {'M', 36},
            {'C', 24 },
            {'W', 30 }
        };

        public int GetItemStock(char itemId)
        {
            return _itemsStock[itemId];
        }

        public void CheckItemStock(char itemId)
        {
            if (_itemsStock[itemId] <= 0)
            {
                throw new Exception("Not enought stock");
            }
        }

        public void ReduceItemStock(char itemId)
        {
            _itemsStock[itemId] -= 1;
        }
    }
}