using System.Collections.Generic;
using System.Linq;

namespace MetalBandBakery.PriceServicesWebAPI.Repositories
{
    public class ItemPriceRepository : IItemPriceRepository
    {
        static ItemPriceRepository()
        {
        }

        private static Dictionary<string, int> _recipeList;

        static ItemPriceRepository()
        {
            ReadStock();
        }

        private static void ReadStock()
        {
            StreamReader sReader = new StreamReader(@"C:\Users\gteam\source\repos\Etapa2\HeavyMetalBakeSale-Project\src\MetalBandBakery.RecipeWCF\App_Code\Archives\StockWithIngredients.json");
            var json = sReader.ReadToEnd();
            _recipeList = JsonConvert.DeserializeObject<List<Recipe>>(json);
            sReader.Close();
        }

        public ItemPrice Get(string itemId)
        {
            if (!Exists(itemId))
                return null;
            return new ItemPrice
            {
                ItemId = itemId,
                Price = _prices[itemId]
            };
        }

        public List<ItemPrice> GetAll()
        {
            return _prices.Select(x => new ItemPrice
            {
                ItemId = x.Key,
                Price = x.Value
            }).ToList();
        }

        public void UpdatePrice(ItemPrice itemPrice)
        {
            if (Exists(itemPrice.ItemId))
                _prices[itemPrice.ItemId] = itemPrice.Price;
        }

        private bool Exists(string itemId)
        {
            return _prices.ContainsKey(itemId);
        }
    }
}