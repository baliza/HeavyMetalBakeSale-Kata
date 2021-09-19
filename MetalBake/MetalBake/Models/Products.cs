using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Products
    {
        public string _Name;
        public char _Id;
        private Dictionary<char, string> productNames = new Dictionary<char, string>
        {
            {'B', "Brownie" },
            {'M', "Mufflin"},
            {'C', "Cake Pop" },
            {'W', "Water" }
        };
        public Products(char id)
        {
            _Name = productNames[id];
            _Id = id;
        }
        public string GetNameProd()
        {
            return _Name;
        }
        public string GetIdProd()
        {
            return _Id;
        }
    }
}
