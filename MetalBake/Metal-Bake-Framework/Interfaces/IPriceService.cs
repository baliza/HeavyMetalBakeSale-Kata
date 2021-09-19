using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    interface IPriceService
    {
        public decimal GetPrice(char key);
        public decimal CalculateOrderPrice(List<Tuple<char, int>> orderList);
    }
}
