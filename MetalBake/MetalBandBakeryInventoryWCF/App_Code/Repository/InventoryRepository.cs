using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class InventoryRepository : IInventoryRepository
{
    private static Dictionary<string, int> _stock;

    static InventoryRepository()
    {
        _stock = new Dictionary<string, int>() { { "B", 30 }, { "M", 36 }, { "C", 24 }, { "W", 0 } };
    }

    public Item GetItem(string itemId)
    {
        if (!Exists(itemId))
            return null;
        return new Item
        {
            ItemId = itemId,
            Quantity = _stock[itemId]
        };
    }

    public bool Save(Item item)
    {
        if (!Exists(item.ItemId))
            return false;
        _stock[item.ItemId] = item.Quantity;
        return true;
    }

    private bool Exists(string itemId)
    {
        return _stock.ContainsKey(itemId);
    }
}