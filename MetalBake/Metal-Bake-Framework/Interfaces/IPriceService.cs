using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static MetalBake.Services.PriceService;

namespace MetalBake.Interfaces
{
    public interface IPriceService
    {
        decimal GetPrice(string key);
        decimal CalculateOrderPrice(List<Tuple<string, int>> orderList);
        List<ItemPrice> GetAllPrices();
    }
}
