using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetalBake.Models
{
    public class Inventory
    {
        public List<Item> ItemList;

        public Inventory()
        {
            List<Item> itemList = new List<Item>();
            itemList.Add(new Item('C',"Cake", 10));
            itemList.Add(new Item('W', "Water", 7));
            itemList.Add(new Item('B', "Brownie", 21));
            itemList.Add(new Item('M', "Muffin", 2));
            ItemList = itemList;
        }

        public bool isOnStock(Item item)
        {
            return item.Amount > 0;
        }

        public override string ToString()
        {
            string first = string.Join("\n", ItemList.Select(e => e.ToString()).ToArray());
            return first;
        }
    }
}
