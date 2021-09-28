using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace WebApplication1.Repositories
{
    public class ItemPriceRepository : IItemPriceRepository
    {
        private static Dictionary<string, decimal> _prices;
        private static string _priceJsonPath = @"C:\Users\nettrim\source\repos\HeavyMetalBakeSale-Kata\MetalBake\MetalBandBakery.Core\App_Data\price.json";

        static ItemPriceRepository()
        {
            var dictJson = File.ReadAllText(_priceJsonPath);
            var dict = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(dictJson);
            _prices = dict;
        }

        public ItemPrice Get(string itemId)
        {
            if (!Exists(itemId))
                return null;
            return new ItemPrice
            {
                ItemId = itemId,
                Price = _prices[itemId]
            };
        }

        public List<ItemPrice> GetAll()
        {
            return _prices.Select(x => new ItemPrice
            {
                ItemId = x.Key,
                Price = x.Value
            }).ToList();
        }

        public void PostUpdatePrice(string itemData)
        {
            ItemPrice item = JsonConvert.DeserializeObject<ItemPrice>(itemData);
            if (!Exists(item.ItemId))
                return;
            _prices[item.ItemId] = item.Price;
            var dict = JsonConvert.SerializeObject(_prices);
            File.WriteAllText(_priceJsonPath, dict);
        }

        private bool Exists(string itemId)
        {
            return _prices.ContainsKey(itemId);
        }
    }
}