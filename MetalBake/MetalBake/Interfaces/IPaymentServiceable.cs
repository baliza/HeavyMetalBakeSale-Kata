using MetalBake.Models;
using System.Collections.Generic;

namespace MetalBake.Services
{
    interface IPaymentServiceable
    {
        bool CoinsAreEnough(Product product, decimal totalCoins);
        bool NeedMoneyBack(Product product, decimal totalCoins);
        bool CoinsAreEnoughMultiple(Dictionary<Product, int> products, decimal totalCoins);
        bool NeedMoneyBackMultiple(Dictionary<Product, int> products, decimal totalCoins);
        decimal CalculateDifference(Dictionary<Product, int> products, decimal totalCoins);
    }
}