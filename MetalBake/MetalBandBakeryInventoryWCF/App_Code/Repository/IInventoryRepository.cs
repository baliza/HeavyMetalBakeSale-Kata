using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public interface IInventoryRepository
{
    Item GetItem(string itemId);

    bool Save(Item item);
}