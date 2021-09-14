using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Products
    {
        public string _Key;
        public string _Name;
        public decimal _Price;

        public Products(string key, string name, decimal price)
        {
            _Key = key;
            _Name = name;
            _Price = price;
        }
    }
}
