using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class StockService : IStockService
    {
        private Dictionary<string, int> _inventory;
        public StockService()
        {
            _inventory = new Dictionary<string, int>
           {
            {"B", 40 },
            {"M", 36 },
            {"C", 24 },
            {"W", 30 }
            };
        }
        public bool Exist(string item)
        {
           return item.Equals(_inventory[item]);       
        }
        public int GetStock(string key)
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
        public bool CheckStock(string item, int amount)
        {
            return _inventory[item] > amount;
        }
        public void ReduceStock(string item, int amount)
        {
            _inventory[item]-=amount;
        }
        public Dictionary<string, int> GetAllStock()
        {
            return _inventory;
        }
    }
}
