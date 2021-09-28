using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MetalBandBakery.InventoryWCF.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private static Dictionary<string, int> _stock;

        static InventoryRepository()
        {
            ReadStock();
        }

        private static void ReadStock()
        {
            StreamReader sReader = new StreamReader(@"C:\Users\gteam\source\repos\Etapa2\HeavyMetalBakeSale-Project\src\MetalBandBakery.InventoryWCF\App_Code\Archives\Stock.json");
            var json = sReader.ReadToEnd();
            _stock = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
            sReader.Close();
        }

        public List<Item> GetAllItems()
        {
            List<Item> itemList = new List<Item>();
            foreach (var stockItem in _stock)
            {
                itemList.Add(new Item(stockItem.Key, stockItem.Value));
            }
            return itemList;
        }

        public Item GetItem(string itemId)
        {
            if (!Exists(itemId))
                return null;
            return new Item
            {
                ItemId = itemId,
                Quantity = _stock[itemId]
            };
        }

        public bool Save(Item item)
        {
            if (!Exists(item.ItemId))
                return false;
            _stock[item.ItemId] = item.Quantity;
            File.WriteAllText(@"C:\Users\gteam\source\repos\Etapa2\HeavyMetalBakeSale-Project\src\MetalBandBakery.InventoryWCF\App_Code\Archives\Stock.json",
                        JsonConvert.SerializeObject(_stock));
            return true;
        }

        private bool Exists(string itemId)
        {
            return _stock.ContainsKey(itemId);
        }
    }
}