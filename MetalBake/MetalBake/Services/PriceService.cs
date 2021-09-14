using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PriceService
    {
        private Dictionary<char, decimal> _listPrices = new Dictionary<char, decimal>
        {
            {'B', 0.65m },
            {'M', 1.00m},
            {'C', 1.35m },
            {'W', 1.50m }
        };

        public decimal CalculateOrderPrice(List<Tuple<char, int>> orderList)
        {
            decimal totalPrice = 0;
            foreach (var item in orderList)
            {
                totalPrice += item.Item2 * _listPrices[item.Item1];
            }
            return totalPrice;
        }
        public void PrintPrice()
        {
            foreach (var item in _listPrices)
            {
                Console.WriteLine($"Sort: {item.Key} Price: {item.Value}");
            }
        }

    }
}
