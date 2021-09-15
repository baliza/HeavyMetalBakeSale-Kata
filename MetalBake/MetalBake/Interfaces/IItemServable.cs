using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    interface IItemServable
    {
        public void PrintItemList();
        public List<Item> GetItemList();
    }
}
