using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    interface IPriceable
    {
        decimal CalculateOrderPrice(List<Tuple<char, int>> orderList);
    }
}
