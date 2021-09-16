using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class PaymentService : IPaymentServiceable
    {
        public bool NeedMoneyBack(Product product, decimal totalCoins)
        {
            if (totalCoins > product._price)
            {
                return true;
            }
            return false;
        }

        public bool CoinsAreEnough(Product product, decimal totalCoins)
        {
            if (totalCoins < product._price)
            {
                return false;
            }
            return true;
        }

        public bool CoinsAreEnoughMultiple(Dictionary<Product, int> products, decimal totalCoins)
        {
            decimal tot = 0;
            decimal aux = 0;
            foreach (var i in products)
            {
                aux = i.Value * i.Key._price;
                tot += aux;
            }

            if (totalCoins >= tot)
            {
                return true;
            }
            return false;
        }

        public bool NeedMoneyBackMultiple(Dictionary<Product, int> products, decimal totalCoins)
        {
            decimal tot = 0;
            decimal aux = 0;
            foreach (var i in products)
            {
                aux = i.Value * i.Key._price;
                tot = tot + aux;
            }

            if (totalCoins > tot)
            {
                return true;
            }

            return false;
        }

        public decimal CalculateDifference(Dictionary<Product, int> products, decimal totalCoins)
        {
            decimal tot = 0;
            decimal aux = 0;
            foreach (var i in products)
            {
                aux = i.Value * i.Key._price;
                tot = tot + aux;
            }

            return totalCoins - tot;
        }
    }
}
