using MetalBake.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.core.Services
{
    public class StockService : IStockService
    {
        private static Dictionary<string, int> _inventory;
        public class ItemStock
        {
            public string ItemId { get; set; }
            public int Amount { get; set; }
            public string Name { get; set; }
        }
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
        public List<ItemStock> GetAllStock()
        {
            IItemService itemName = new ItemService();
            List<ItemStock> allStock = new List<ItemStock>();
            foreach (var item in _inventory)
            {
                allStock.Add(new ItemStock() { ItemId = item.Key, Name = itemName.GetItem(item.Key).ToString(), Amount = item.Value });
            }
            return allStock;
        }
    }
}
