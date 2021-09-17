using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Item
    {
        private readonly string _name;
        private readonly string _itemId;

        public Item(string name, string itemId)
        {
            _itemId = itemId;
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}