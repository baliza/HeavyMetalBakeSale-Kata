using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    interface IItemService
    {
        public void PrintItemList();
        public List<Item> GetItemList();
    }
}
