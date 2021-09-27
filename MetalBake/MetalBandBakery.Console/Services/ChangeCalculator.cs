using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.Console.Services
{
    public class ChangeCalculator
    {
        public static decimal Calculate(decimal amountPaid, decimal amountToPay)
        {
            return amountPaid - amountToPay;
        }

        public static bool CanBeCalculate(decimal amountPaid, decimal amountToPay)
        {
            return amountPaid > amountToPay;
        }
    }
}