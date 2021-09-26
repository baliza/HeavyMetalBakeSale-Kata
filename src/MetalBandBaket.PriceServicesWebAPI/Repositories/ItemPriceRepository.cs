using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MetalBandBakery.PriceServicesWebAPI.Repositories
{
    public class ItemPriceRepository : IItemPriceRepository
    {
        private Dictionary<string, decimal> _ingredientsPrice;
        private RecipeRepository _recipeRepository;

        public ItemPriceRepository()
        {
            ReadIngredients();
            UpdateRecpeRepository();
        }

        private void UpdateRecpeRepository()
        {
            _recipeRepository = new RecipeRepository();
        }

        private void ReadIngredients()
        {
            StreamReader sReader = new StreamReader(@"C:\Users\gteam\source\repos\Etapa2\HeavyMetalBakeSale-Project\src\MetalBandBaket.PriceServicesWebAPI\Repositories\Archives\Ingredients.json");
            var json = sReader.ReadToEnd();
            _ingredientsPrice = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(json);
            sReader.Close();
        }

        public ItemPrice Get(string itemId)
        {
            if (!Exists(itemId))
                return null;
            return new ItemPrice
            {
                ItemId = itemId,
                Price = CalculatePriceById(itemId)
            };
        }

        private decimal CalculatePriceById(string itemId)
        {
            Recipe recipeItem = _recipeRepository.GetRecipe(itemId);
            decimal totalPrice = recipeItem.Extra;
            decimal ingredientPrice = -1;
            foreach (var item in recipeItem.Ingredients)
            {
                ingredientPrice = _ingredientsPrice[item.Key];
                if (ingredientPrice != null)
                    totalPrice += ingredientPrice * (item.Value/1000);
            }
            return totalPrice;
        }

        public List<ItemPrice> GetAll()
        {
            var priceList = new List<ItemPrice>();
            foreach (var recipe in _recipeRepository.GetAllRecipes())
            {
                priceList.Add(new ItemPrice()
                {
                    ItemId = recipe.ItemId,
                    Price = CalculatePriceById(recipe.ItemId)
                });
            }

            return priceList;
        }

        private bool Exists(string itemId)
        {
            return _recipeRepository.GetRecipe(itemId) != null;
        }
    }
}