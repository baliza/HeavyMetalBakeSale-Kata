using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class RecipeRepository : IRecipeRepository
{
    private static List<Recipe> _recipeList;

    static RecipeRepository()
    {
        ReadRecipeList();
    }

    private static void ReadRecipeList()
    {
        StreamReader sReader = new StreamReader(@"C:\Users\gteam\source\repos\Etapa2\HeavyMetalBakeSale-Project\src\MetalBandBaket.PriceServicesWebAPI\Repositories\Archives\StockWithIngredients.json");
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
                    File.WriteAllText(@$"C:\Users\gteam\source\repos\Etapa2\HeavyMetalBakeSale-Project\src\MetalBandBaket.PriceServicesWebAPI\Repositories\Archives\StockWithIngredients.json",
                        JsonConvert.SerializeObject(_recipeList));
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