using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IPriceService
    {
        decimal GetPrice(char key);
        decimal CalculateOrderPrice(List<Tuple<char, int>> orderList);
    }
}
