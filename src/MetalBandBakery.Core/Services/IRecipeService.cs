using System.Collections.Generic;

namespace MetalBandBakery.Core.Services
{
    public interface IRecipeService
    {
        Recipe GetRecipe(string itemId);

        bool SaveRecipe(Recipe recipe);

        List<Recipe> GetAllRecipes();
    }
}