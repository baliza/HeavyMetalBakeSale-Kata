using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class Calculator
    {
        private static Calculator _PriceCalculator;

        private Calculator() { }

        public static Calculator GetInstance()
        {
            if (_PriceCalculator == null)
            {
                return new Calculator();
            }
            return _PriceCalculator;
        }
    }
}
