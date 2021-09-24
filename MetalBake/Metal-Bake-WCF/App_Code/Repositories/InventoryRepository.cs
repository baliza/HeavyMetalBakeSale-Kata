using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetalBake.Services
{
    public class InventoryRepository : IInventoryRepository
    {
        private static Dictionary<string, int> _inventory;
        static InventoryRepository()
        {
            _inventory = new Dictionary<string, int>
           {
            {"B", 40 },
            {"M", 36 },
            {"C", 24 },
            {"W", 30 }
            };
        }
        public bool Exist(string id)
        {
            return _inventory.ContainsKey(id);       
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
        public void IncreaseStock(string item, int amount)
        {
            _inventory[item] += amount;
        }
        public bool SetItemStock(string itemId, int amount)
        {
            if (Exist(itemId))
            {
                _inventory[itemId] += amount;
                return true;
            }
            return false;
        }
        public List<ItemStock> GetAllStock()
        {
            return _inventory.Select(item => new ItemStock { ItemId = item.Key, Stock = item.Value }).ToList();
        }
    }
}
