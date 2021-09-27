using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KataMuffin.Models
{
    public class Product
    {
        public string Name;
        public double Price;
        public string Id;

        public Product(string name, double price, string id)
        {
            Name = name;
            Price = price;
            Id = id;
        }
    }
}