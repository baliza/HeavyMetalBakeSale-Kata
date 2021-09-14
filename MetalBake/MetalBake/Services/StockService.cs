using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    class StockService : IStockable
    {
        private Dictionary<char, int> _inventory = new Dictionary<char, int>
        {
            {'B', 40 },
            {'M', 36 },
            {'C', 24 },
            {'W', 30 }
        };
        public bool Exist(char item)
        {
            if (item.Equals(_inventory[item]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckStock(char item, int amount)
        {
            return _inventory[item] > amount;
        }
        public void ReduceStock(char item, int amount)
        {
            _inventory[item]-=amount;
        }
    }
}
