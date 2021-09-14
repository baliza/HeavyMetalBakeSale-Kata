using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Item
    {
        public string Name;
        public char Sort;

        public Item(char key)
        {
            SetName(key);
            Sort = key;
        }

        private void SetName(char key)
        {
            if (key.Equals('B'))
            {
                Name = "Brownie";
            }
            if(key.Equals('M'))
            {
                Name = "Muffin";
            }
            if (key.Equals('C'))
            {
                Name = "Cake Pop";
            }
            if (key.Equals('W'))
            {
                Name = "Water";
            }
        }
    }
}
