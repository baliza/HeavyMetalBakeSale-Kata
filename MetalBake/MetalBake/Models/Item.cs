using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Item
    {
        private readonly string _name;
        private readonly string _itemId;

        public static Dictionary<string, string> ItemsNames = new Dictionary<string, string>
        {
            {"B", "Brownie" },
            {"M", "Muffin" },
            {"C", "Cake Pop" },
            {"W", "Water" }
        };

        public Item(string itemId)
        {
            _itemId = itemId;
            _name = ItemsNames[itemId];
        }

        public string GetName()
        {
            return _name;
        }

        public string GetItemId()
        {
            return _itemId;
        }
    }
}