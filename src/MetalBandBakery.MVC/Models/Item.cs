using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBandBakery.MVC.Models
{
    public class Item
    {
        public Item(string itemId, int quantity, decimal price)
        {
            ItemId = itemId;
            this.Quantity = quantity;
            this.Price = price;
        }

        public Item()
        {
        }

        public string ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}