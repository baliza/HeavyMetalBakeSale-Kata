using MetalBake.Models;
using System.Collections.Generic;

namespace MetalBake.Services
{
    public interface IPaymentServiceable
    {
        bool CoinsAreEnough(decimal price, decimal totalCoins);
        bool NeedMoneyBack(decimal price, decimal totalCoins);
    }
}