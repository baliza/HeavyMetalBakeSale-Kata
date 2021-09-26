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
            MetalBandBakery.MVC.Models.Recipe recipeMVC = new MetalBandBakery.MVC.Models.Recipe()
            {
                ItemId = recipeApi.ItemId,
                Ingredients = recipeApi.Ingredients,
                Extra = recipeApi.Extra
            };
            return View(recipeMVC);
        }

        public ActionResult SetRecipeBake(Models.Recipe recipe)
        {
            _priceService.UpdateRecipe(recipe.ItemId, recipe.Ingredients, recipe.Extra);
            return RedirectToAction("Index", "Stock");
        }
    }
}