using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PieMarketService
    {
        public static double GetPrice(Item item)
        {
            return item.Price;
        }

        public static double GenerateNewPrice()
        {
            Random random = new Random();

            return Math.Round(random.NextDouble() * (0.5) + 0.5 , 2);
        }
    }
}
