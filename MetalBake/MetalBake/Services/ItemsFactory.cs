using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class ItemsFactory
    {
        private static readonly Dictionary<char, string> items = new Dictionary<char, string>
        {
            {'B', "Brownie" },
            {'M', "Muffin" },
            {'C', "Cake Pop" },
            {'W', "Water" }
        };

        public static Item CreateItem(char key)
        {
            return new Item(key, items[key]);
        }
    }
}
