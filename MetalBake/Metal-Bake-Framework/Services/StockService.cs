using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class StockService : IStockService
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
           return item.Equals(_inventory[item]);       
        }
        public int GetStock(char key)
        {
            foreach (var item in _inventory)
            {
                if (key.Equals(item.Key))
                {
                    return item.Value;
                }
            }
            return 0;
        }
        public bool CheckStock(char item, int amount)
        {
            return _inventory[item] > amount;
        }
        public void ReduceStock(char item, int amount)
        {
            _inventory[item]-=amount;
        }
        public void PrintStock()
        {
            foreach (var item in _inventory)
            {
                Console.WriteLine($"Sort: {item.Key}  Amount: {item.Value}");
            }
        }
    }
}
