using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Item
    {
        private readonly string _name;
        private readonly char _sort;

        public Item(string name, char sort)
        {
            _sort = sort;
            _name = name;
        }
    }
}