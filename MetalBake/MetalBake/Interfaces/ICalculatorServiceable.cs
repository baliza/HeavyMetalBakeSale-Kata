using MetalBake.Models;
using System.Collections.Generic;

namespace MetalBake.Services
{
    public interface ICalculatorServiceable
    {
        decimal CalculateDifference(Dictionary<Product, int> products, decimal totalCoins);
        decimal CalculateTotalOfDictionary(Dictionary<Product, int> products);
    }
}