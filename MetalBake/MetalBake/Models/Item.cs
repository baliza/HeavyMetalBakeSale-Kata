using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Item
    {
        public string Name;
        public char Sort;

        public Item(string name, char sort)
        {
            Name = name;
            Sort = sort;
        }
    }
}
