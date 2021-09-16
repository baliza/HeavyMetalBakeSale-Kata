using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Order
    {
        private readonly List<Item> _buyItemsList;
        public decimal TotalPrice { get; set; }

        public Order()
        {
            _buyItemsList = new List<Item>();
        }

        public void AddItem(Item item, decimal price)
        {
            _buyItemsList.Add(item);
            TotalPrice += price;
        }
    }
}