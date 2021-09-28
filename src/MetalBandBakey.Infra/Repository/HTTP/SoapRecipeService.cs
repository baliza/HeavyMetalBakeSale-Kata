using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalBandBakery.Core.Services;
using WRecipe = MetalBandBakey.Infra.WCFRecipeService;

namespace MetalBandBakey.Infra.Repository.HTTP
{
    public class SoapRecipeService : IRecipeService
    {
        private WRecipe.IRecipeService _svc;

        public SoapRecipeService()
        {
            _svc = new WRecipe.RecipeServiceClient();
        }

        public List<Recipe> GetAllRecipes()
        {
            Recipe[] recipes = _svc.GetAllRecipes();
            var recipeList = new List<Recipe>();
            foreach (var recipe in recipes)
            {
                recipeList.Add(recipe);
            }
            return recipeList;
        }

        public Recipe GetRecipe(string itemId)
        {
            return _svc.GetRecipe(itemId);
        }

        public bool SaveRecipe(Recipe recipe)
        {
            return _svc.SaveRecipe(recipe);
        }
    }
}