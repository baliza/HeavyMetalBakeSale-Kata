using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Order
    {
        private List<Products> productList;
        private decimal total { get; set; }

        public Order()
        {
            productList = new List<Products>();
        }
        public void ProductAdd(Products name, decimal price)
        {
            productList.Add(name);
            total += price;
        }
    }
}
