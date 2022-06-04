using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class PriceRepository : IPriceRepository
{
    private static Dictionary<string, decimal> _itemsPrices;

    static PriceRepository()
    {
        _itemsPrices = new Dictionary<string, decimal>() { { "B", 0.65M }, { "M", 1 }, { "C", 1.35M }, { "W", 1.5M } };
    }

    public ItemPrice GetItemPrice(string itemId)
    {
        if (!ExistsItem(itemId))
        {
            return null;
        }
        return new ItemPrice
        {
            ItemId = itemId,
            Price = _itemsPrices[itemId]
        };
    }

    public List<ItemPrice> GetAllPrices()
    {
        return _itemsPrices.Select(item => new ItemPrice
        {
            ItemId = item.Key,
            Price = item.Value
        }).ToList();
    }

    public bool UpdateItemPrice(string itemId, decimal newPrice)
    {
        if (!ExistsItem(itemId))
        {
            return false;
        }
        _itemsPrices[itemId] = newPrice;
        return true;
    }

    private bool ExistsItem(string itemId)
    {
        return _itemsPrices.ContainsKey(itemId);
    }
}