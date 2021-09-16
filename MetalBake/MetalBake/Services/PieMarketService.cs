using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PieMarketService
    {
        public static double GenerateNewPrice()
        {
            Random random = new Random();

            return Math.Round(random.NextDouble() * (0.5) + 0.5, 2);
        }
        public static double GetPrice(Item item)
        {
            if (item.Code == 'M')
            {
                return 1.20;
            }
            else if (item.Code == 'W')
            {
                return 0.60;
            }
            else if (item.Code == 'B')
            {
                return 0.85;
            }
            else if (item.Code == 'C')
            {
                return 0.23;
            }
            return -1;
        }
    }
}