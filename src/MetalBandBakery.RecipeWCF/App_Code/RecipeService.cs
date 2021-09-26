using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class RecipeService : IRecipeService
{
    private IRecipeRepository _recipeRepo;

    public RecipeService()
    {
        _recipeRepo = new RecipeRepository();
    }

    public List<Recipe> GetAllRecipes()
    {
        return _recipeRepo.GetAllRecipes();
    }

    public Recipe GetRecipe(string itemId)
    {
        return _recipeRepo.GetRecipe(itemId);
    }

    public bool SaveRecipe(Recipe recipe)
    {
        return _recipeRepo.SaveRecipe(recipe);
    }
}