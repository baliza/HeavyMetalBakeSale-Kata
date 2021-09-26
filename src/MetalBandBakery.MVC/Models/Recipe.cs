using System.Collections.Generic;

namespace MetalBandBakery.MVC.Models
{
    public class Recipe
    {
        public string ItemId { get; set; }
        public Dictionary<string, int> Ingredients { get; set; }
        public decimal Extra { get; set; }

        public Recipe()
        {
            Ingredients = new Dictionary<string, int>();
        }

        public Recipe(string itemId, decimal extra)
        {
            ItemId = itemId;
            Ingredients = new Dictionary<string, int>();
            Extra = extra;
        }
    }
}