using MetalBandBakery.PriceServicesWebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace MetalBandBaket.PriceServicesWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly ILogger<PricesController> _logger;

        public RecipesController(ILogger<PricesController> logger)
        {
            _logger = logger;
        }

        [Route("UpdateIngredientList")]
        [HttpPost]
        public void UpdateIngredientList(Recipe itemRecipe)
        {
            IRecipeRepository repository = new RecipeRepository();
            repository.SaveRecipe(itemRecipe);
        }

        [Route("GetRecipes")]
        [HttpGet]
        public IEnumerable<Recipe> GetRecipes()
        {
            IRecipeRepository repository = new RecipeRepository();
            var itemRecipeList = repository.GetAllRecipes();
            return itemRecipeList;
        }

        [Route("GetRecipes/{itemId}")]
        [HttpGet]
        public Recipe GetRecipes(string itemId)
        {
            IRecipeRepository repository = new RecipeRepository();
            var itemRecipe = repository.GetRecipe(itemId);
            return itemRecipe;
        }
    }
}