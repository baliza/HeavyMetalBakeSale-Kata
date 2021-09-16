using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PaymentService : IPaymentServiceable
    {
        public bool NeedMoneyBack(decimal price, decimal totalCoins)
        {
            if (totalCoins > price)
            {
                return true;
            }
            return false;
        }

        public bool CoinsAreEnough(decimal price, decimal totalCoins)
        {
            if (totalCoins < price)
            {
                return false;
            }
            return true;
        }
    }
}
