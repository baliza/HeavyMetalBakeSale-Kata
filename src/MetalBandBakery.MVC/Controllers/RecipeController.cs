using MetalBandBakery.Core.Services;
using MetalBandBakery.MVC.Models;
using Infra = MetalBandBakey.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBandBakery.MVC.Controllers
{
    public class RecipeController : Controller
    {
        private static IPriceService _priceService = new Infra.RestfullPriceService();
        private static Dictionary<string, int> ingredientsTest = new Dictionary<string, int>();

        // GET: Recipe
        public ActionResult Index()
        {
            var recipeApi = _priceService.GetRepice("B");
            Recipe recipeMVC = new Recipe()
            {
                ItemId = recipeApi.ItemId,
                Ingredients = recipeApi.Ingredients,
                Extra = recipeApi.Extra
            };
            return View(recipeMVC);
        }

        public ActionResult Edit(string id)
        {
            var recipeApi = _priceService.GetRepice(id);
            ingredientsTest = recipeApi.Ingredients;

            MetalBandBakery.MVC.Models.Recipe recipeMVC = new MetalBandBakery.MVC.Models.Recipe()
            {
                ItemId = recipeApi.ItemId,
                Ingredients = recipeApi.Ingredients,
                Extra = recipeApi.Extra
            };
            return View(recipeMVC);
        }

        public void EditIngredient(string id, int quantity)
        {
            if (ingredientsTest.ContainsKey(id))
            {
                ingredientsTest[id] = quantity;
            }
        }

        [HttpPost]
        public ActionResult SetRecipeBake(Recipe recipe)
        {
            //ingredientQuantity = 1;
            foreach (var r in recipe.Ingredients)
            {
                EditIngredient(r.Key, r.Value);
            }
            _priceService.UpdateRecipe(recipe.ItemId, ingredientsTest, recipe.Extra);
            return RedirectToAction("Index", "Stock");
        }
    }
}