using MetalBandBakery.Core.Services;
using MetalBandBakey.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.ManagerLibrary.RestFull
{
    public class RestFullPrice : IPriceService
    {
        private IPriceService rService;

        public RestFullPrice()
        {
            rService = new RestfullPriceService();
        }

        public IEnumerable<Recipe> GetAllRepices()
        {
            return rService.GetAllRepices();
        }

        public decimal GetPrice(string itemId)
        {
            return rService.GetPrice(itemId);
        }

        public Recipe GetRepice(string itemId)
        {
            return rService.GetRepice(itemId);
        }

        public void UpdateRecipe(string itemId, Dictionary<string, int> ingredients, decimal extra)
        {
            rService.UpdateRecipe(itemId, ingredients, extra);
        }
    }
}