using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    class Item : IItemable
    {
        private string _short { get; set; }
        private string _name { get; set; }
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
