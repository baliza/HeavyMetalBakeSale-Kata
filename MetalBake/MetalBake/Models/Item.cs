using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Item
    {
        public string Name;
        public char Sort;

        public Item(char key, string name)
        {
            Name = name;
            Sort = key;
        }

    }
}
