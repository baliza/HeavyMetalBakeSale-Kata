using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IItemService
    {
        void PrintItemList();
        List<Item> GetItemList();
    }
}
