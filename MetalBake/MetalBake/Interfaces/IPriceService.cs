using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IPriceService
    {
        public decimal GetPrice(string key);
        public decimal CalculateOrderPrice(List<Tuple<string, int>> orderList);
        public List<ItemPrice> GetAllPrices();
    }
}
