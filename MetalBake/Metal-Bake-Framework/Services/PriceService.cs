using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PriceService : IPriceService
    {
        private Dictionary<string, decimal> _listPrices;
        public class ItemPrice
        {
            public string itemId { get; set; }
            public decimal price { get; set; }
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
        public void PrintPrice()
        {
            foreach (var item in _listPrices)
            {
                Console.WriteLine($"Sort: {item.Key} Price: {item.Value}");
            }
        }

        public List<ItemPrice> GetAllPrices()
        {
            List<ItemPrice> listPrices = new List<ItemPrice>();
            foreach (var item in _listPrices)
            {
                listPrices.Add(new ItemPrice() {itemId = item.Key, price = item.Value });
            }
            return listPrices;
        }
    }
}
