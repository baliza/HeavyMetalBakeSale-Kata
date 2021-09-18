using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class ChangeService : IChangeService
    {
        public decimal GetChange(decimal totalPrice, decimal amountForPay)
        {
            if (amountForPay < totalPrice)
            {
                return -1;
            }
            return amountForPay - totalPrice;
        }
    }
}