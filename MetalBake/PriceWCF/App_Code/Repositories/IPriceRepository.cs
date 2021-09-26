using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public interface IPriceRepository
{
    decimal GetPrice(string key);
    decimal CalculateOrderPrice(Dictionary<string, int> orderList);
    List<ItemPrice> GetAllPrices();
    decimal SetPrice(ItemPrice item);
    void TxtListPrice();
}
