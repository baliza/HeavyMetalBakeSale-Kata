using MetalBandBakery.Core.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace MetalBandBakey.Infra.Repository
{
    public class RestfullPriceService : IPriceService
    {
        public class ItemPrice
        {
            public string itemId { get; set; }
            public decimal price { get; set; }
        }

        public decimal GetPrice(string itemId)
        {
            string apiUrl = "https://localhost:44350/prices";

            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}/{itemId}");
                var itemPrice = JsonConvert.DeserializeObject<ItemPrice>(json);
                if (itemPrice == null)
                    return -1;
                return itemPrice.price;
            }
        }

        public IEnumerable<Recipe> GetAllRepices()
        {
            string apiUrl = "https://localhost:44350/recipes/getRecipes";

            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}");
                var recipeList = JsonConvert.DeserializeObject<List<Recipe>>(json);
                return recipeList;
            }
        }

        public Recipe GetRepice(string itemId)
        {
            string apiUrl = "https://localhost:44350/recipes/getRecipes";

            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}/{itemId}");
                var recipe = JsonConvert.DeserializeObject<Recipe>(json);
                return recipe;
            }
        }

        public void UpdateRecipe(string itemId, Dictionary<string, int> ingredients, decimal extra)
        {
            string apiUrl = "https://localhost:44350/recipes/UpdateIngredientList";

            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                Recipe recipe = new Recipe()
                {
                    ItemId = itemId,
                    Ingredients = ingredients,
                    Extra = extra
                };
                string json = JsonConvert.SerializeObject(recipe);
                client.UploadString(apiUrl, json);
            }
        }
    }
}