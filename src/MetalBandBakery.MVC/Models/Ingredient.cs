using System.Collections.Generic;

namespace MetalBandBakery.MVC.Models
{
    public class Ingredient
    {
        public string ItemId { get; set; }
        public string IngredientId { get; set; }
        public int IngredientQuantity { get; set; }
        public decimal Extra { get; set; }

        public Ingredient()
        {
        }
    }
}