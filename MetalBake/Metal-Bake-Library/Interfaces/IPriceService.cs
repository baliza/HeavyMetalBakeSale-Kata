using MetalBake.core.Models;
using System.Collections.Generic;

namespace MetalBake.Services
{
    public interface IPriceService
    {
        decimal GetPrice(string key);
        decimal CalculateOrderPrice(Dictionary<string, int> orderList);
        List<ItemPrice> GetAllPrices();
        decimal SetPrice(ItemPrice item);
    }
}