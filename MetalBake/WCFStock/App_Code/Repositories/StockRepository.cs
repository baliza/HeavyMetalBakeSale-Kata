using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class StockRepository : IStockRepository
{
    private static Dictionary<string, int> _itemsStock = new Dictionary<string, int>
        {
            {"B", 40 },
            {"M", 36},
            {"C", 24 },
            {"W", 2 }
        };

    public int GetItemStock(string itemId)
    {
        return _itemsStock[itemId];
    }

    public void SetItemStock(string itemId, int value)
    {
        if (ContainsItem(itemId))
        {
            _itemsStock[itemId] = value;
        }
    }

    public bool ContainsItem(string itemId)
    {
        return _itemsStock.ContainsKey(itemId);
    }
}