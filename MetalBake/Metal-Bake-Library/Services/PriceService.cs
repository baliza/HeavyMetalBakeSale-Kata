using MetalBake.core.Interfaces;
using MetalBake.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.Services
{
    public class PriceService : IPriceService
    {
        private static Dictionary<string, decimal> _listPrices;
        static PriceService()
        {
            _listPrices = new Dictionary<string, decimal>
            {
            { "B", 0.65m },
            { "M", 1.00m},
            { "C", 1.35m },
            { "W", 1.50m }
            };
        }
        public decimal CalculateOrderPrice(Dictionary<string, int> orderList)
        {
            decimal totalPrice = 0;
            foreach (var item in orderList)
            {
                totalPrice += item.Value * _listPrices[item.Key];
            }
            return totalPrice;
        }
        public decimal GetPrice(string key)
        {
            foreach (var item in _listPrices)
            {
                if (key.Equals(item.Key))
                {
                    return item.Value;
                }
            }
            return 0;
        }
        public List<ItemPrice> GetAllPrices()
        {
            return _listPrices.Select(x => new ItemPrice
            {
                ItemId = x.Key,
                Price = x.Value
            }).ToList();
        }
        public decimal SetPrice(ItemPrice item)
        {
            _listPrices[item.ItemId] = item.Price;
            return item.Price;
        }
    }
}
