using System;
using System.Collections.Generic;
using System.Text;
namespace MetalBake
{
    public class PriceService : IPriceService
    {
        public Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>()
        {
            {"B",0.65m },
            {"M",1.00m },
            {"C",1.35m },
            {"W",1.50m }

        };

        public decimal TotalToPay(string[] itemId)
        {
            decimal total = 0;
            foreach (var item in itemId)
            {
                total = total + productsPrice[item];
            }
            Console.WriteLine($"Amount to paid:{total}$");
            return total;
        }
    }
}