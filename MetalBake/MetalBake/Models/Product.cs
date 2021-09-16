using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Product
    {
        public int _id { get; protected set; }
        public string _name { get; protected set; }
        public decimal _price { get; protected set; }

        public Product(int id, string name, decimal price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public override string ToString()
        {
            return $"{_name} -> {_price}";
        }
    }
}
