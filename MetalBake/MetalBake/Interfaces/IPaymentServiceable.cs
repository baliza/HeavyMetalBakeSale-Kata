using MetalBake.Models;
using System.Collections.Generic;

namespace MetalBake.Services
{
    public interface IPaymentServiceable
    {
        bool CoinsAreEnough(decimal price, decimal totalCoins);
        bool NeedMoneyBack(decimal price, decimal totalCoins);
        bool CoinsAreEnoughMultiple(Dictionary<Product, int> products, decimal totalCoins);
        bool NeedMoneyBackMultiple(Dictionary<Product, int> products, decimal totalCoins);
        decimal CalculateDifference(Dictionary<Product, int> products, decimal totalCoins);
    }
}