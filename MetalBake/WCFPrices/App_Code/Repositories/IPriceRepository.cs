using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public interface IPriceRepository
{
    ItemPrice GetItemPrice(string itemId);

    List<ItemPrice> GetAllPrices();

    bool UpdateItemPrice(string itemId, decimal newPrice);
}