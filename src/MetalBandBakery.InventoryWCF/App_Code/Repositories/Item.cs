using System.Collections.Generic;

namespace MetalBandBakery.InventoryWCF.Repositories
{
    public class Item
    {
        public string ItemId { get; set; }
        public int Quantity { get; set; }

        /* public List<Dictionary<string, int>> Ingredients { get; set; }

         public decimal Extra { get; set; }*/

        public Item()
        {
            /*Ingredients = new List<Dictionary<string, int>>();*/
        }

        public Item(string itemId, int quantity)
        {
            ItemId = itemId;
            Quantity = quantity;
            /*Ingredients = new List<Dictionary<string, int>>();
            Extra = 0;*/
        }
    }
}