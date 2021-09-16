using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class RepaymentCalculator : IRepaymentCalculator
    {
        private static RepaymentCalculator _PriceCalculator;
        private RepaymentCalculator() { }
        public static RepaymentCalculator GetInstance()
        {
            if (_PriceCalculator == null)
            {
                return new RepaymentCalculator();
            }
            return _PriceCalculator;
        }
        public double getRepayment(double totalMoney, double userMoney)
        {
            if (isEnoughtMoney(totalMoney, userMoney))
            {
                return userMoney - totalMoney;
            }

            return -1;
        }
        private bool isEnoughtMoney(double totalMoney, double userMoney)
        {
            return (userMoney - totalMoney) >= 0;
        }
    }
}
