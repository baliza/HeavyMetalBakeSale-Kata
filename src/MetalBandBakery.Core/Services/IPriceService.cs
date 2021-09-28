using System.Collections.Generic;

namespace MetalBandBakery.Core.Services
{
    public interface IPriceService
    {
        decimal GetPrice(string itemId);

        IEnumerable<Recipe> GetAllRepices();

        Recipe GetRepice(string itemId);

        void UpdateRecipe(string itemId, Dictionary<string, int> ingredients, decimal extra);
    }
}