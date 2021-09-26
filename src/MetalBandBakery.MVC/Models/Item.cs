using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBandBakery.MVC.Models
{
    public class Item
    {
        public Item(string itemId, int quantity, decimal price, Dictionary<string, int> ingredients, decimal extra)
        {
            ItemId = itemId;
            this.Quantity = quantity;
            this.Price = price;
            Ingredients = ingredients;
            Extra = extra;
        }

        public Item()
        {
            Ingredients = new Dictionary<string, int>();
        }

        public string ItemId { get; set; }
        public int Quantity { get; set; }
        public Dictionary<string, int> Ingredients { get; set; }
        public decimal Extra { get; set; }
        public decimal Price { get; set; }
    }
}