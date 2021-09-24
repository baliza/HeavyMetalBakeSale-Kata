using MetalBake.core.Interfaces;
using MetalBake.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.core.Services
{
    public class PriceService : IPriceService
    {
        private static Dictionary<string, decimal> _listPrices;
        public class ItemPrice
        {
            public string Name { get; set; }
            public string ItemId { get; set; }
            public decimal Price { get; set; }
        }
        public PriceService()
        {
            _listPrices = new Dictionary<string, decimal>
            {
            { "B", 0.65m },
            { "M", 1.00m},
            { "C", 1.35m },
            { "W", 1.50m }
            };
        }
        //public decimal CalculateOrderPrice(List<Tuple<string, int>> orderList)
        //{
        //    decimal totalPrice = 0;
        //    foreach (var item in orderList)
        //    {
        //        totalPrice += item.Item2 * _listPrices[item.Item1];
        //    }
        //    return totalPrice;
        //}
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
            IItemService itemName = new ItemService();
            List<ItemPrice> listPrices = new List<ItemPrice>();
            foreach (var item in _listPrices)
            {
                listPrices.Add(new ItemPrice() {ItemId = item.Key, Name = itemName.GetItem(item.Key).ToString(), Price = item.Value });
            }
            return listPrices;
        }
    }
}
