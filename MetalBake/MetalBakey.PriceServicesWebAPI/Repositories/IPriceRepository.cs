using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBakey.PriceServicesWebAPI.Repositories
{
    public interface IPriceRepository
    {
        public decimal GetPrice(string key);
        public decimal CalculateOrderPrice(List<Tuple<string, int>> orderList);
        List<ItemPrice> GetAllPrices();
        void SetPrice(ItemPrice item);
    }
}
