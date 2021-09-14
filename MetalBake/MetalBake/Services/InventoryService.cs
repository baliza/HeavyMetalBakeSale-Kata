using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    class InventoryService
    {
        public List<Item> ItemList;

        public InventoryService(List<Item> itemList)
        {
            ItemList = itemList;
        }


    }
}
