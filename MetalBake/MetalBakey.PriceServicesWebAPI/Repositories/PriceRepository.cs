using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetalBakey.PriceServicesWebAPI.Repositories
{
    public class PriceRepository : IPriceRepository
    {
        private static Dictionary<string, decimal> _listPrices;
        static PriceRepository()
        {
            _listPrices = new Dictionary<string, decimal>
            {
            { "B", 0.65m },
            { "M", 1.00m},
            { "C", 1.35m },
            { "W", 1.50m }
            };
        }
        public decimal CalculateOrderPrice(List<Tuple<string, int>> orderList)
        {
            decimal totalPrice = 0;
            foreach (var item in orderList)
            {
                totalPrice += item.Item2 * _listPrices[item.Item1];
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
        public void SetPrice(ItemPrice item)
        {           
            _listPrices[item.ItemId] = item.Price;
        }
    }
}
