using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    class Item
    {
        public string _short;
        public string _name;
        public Item(string Short, string Name)
        {
            _short = Short;
            _name = Name;
        }
        public string GetShort()
        {
            return _short;
        }
        public string GetName()
        {
            return _name;
        }
    }
}
