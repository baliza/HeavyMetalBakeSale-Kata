using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class CalculatorService : ICalculatorServiceable
    {
        public decimal CalculateDifference(Dictionary<Product, int> products, decimal totalCoins)
        {
            decimal tot = 0;
            decimal aux = 0;
            foreach (var i in products)
            {
                aux = i.Value * i.Key._price;
                tot = tot + aux;
            }

            return totalCoins - tot;
        }

        public decimal CalculateTotalOfDictionary(Dictionary<Product, int> products)
        {
            decimal tot = 0;
            decimal aux = 0;
            foreach (var i in products)
            {
                aux = i.Value * i.Key._price;
                tot = tot + aux;
            }

            return tot;
        }
    }
}
