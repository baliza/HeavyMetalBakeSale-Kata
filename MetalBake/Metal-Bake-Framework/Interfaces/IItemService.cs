using MetalBake.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.core.Interfaces
{
    public interface IItemService
    {
        void PrintItemList();
        List<Item> GetItemList();
        string GetItem(string id);

    }
}
