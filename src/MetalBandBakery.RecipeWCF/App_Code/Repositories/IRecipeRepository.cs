using System.Collections.Generic;

public interface IRecipeRepository
{
    Recipe GetRecipe(string itemId);

    bool SaveRecipe(Recipe recipe);

    List<Recipe> GetAllRecipes();
}