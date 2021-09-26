using MetalBake.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.core.Interfaces
{
    public interface IPriceService
    {
        decimal GetPrice(string key);
        decimal CalculateOrderPrice(Dictionary<string, int> orderList);
        List<ItemPrice> GetAllPrices();
        decimal SetPrice(ItemPrice item);
    }
}
