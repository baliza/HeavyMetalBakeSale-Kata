using MetalBandBakery.Core.Domain;
using MetalBandBakery.Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MetalBandBakey.Infra.Repository
{
    public class InMemoryRecipeServices : IRecipeService
    {
        private static List<Recipe> _recipeList;

        static InMemoryRecipeServices()
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

        public List<Recipe> GetAllRecipes()
        {
            return _recipeList;
        }

        public Recipe GetRecipe(string itemId)
        {
            if (Exists(itemId))
            {
                return _recipeList.Where(x => x.ItemId == itemId).FirstOrDefault();
            }
            return null;
        }

        public bool SaveRecipe(Recipe recipe)
        {
            if (Exists(recipe.ItemId))
            {
                for (int i = 0; i < _recipeList.Count(); i++)
                {
                    if (_recipeList[i].ItemId == recipe.ItemId)
                    {
                        _recipeList[i] = recipe;
                        return true;
                    }
                }
            }
            return false;
        }

        private bool Exists(string itemId)
        {
            var count = _recipeList.Where(x => x.ItemId == itemId);

            if (count.Count() > 0)
            {
                return true;
            }
            return false;
        }
    }
}