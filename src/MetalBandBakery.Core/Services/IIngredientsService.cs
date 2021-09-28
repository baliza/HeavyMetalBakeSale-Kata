using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.Core.Services
{
    public interface IIngredientsService
    {
        List<Dictionary<string, int>> GetPriceOfIngredients();

        void UpdatePriceOfIngredients(List<Dictionary<string, int>> ingredientsList);
    }
}