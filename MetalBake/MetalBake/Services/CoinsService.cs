using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class CoinsService : ICoinsServiceable
    {
        public decimal _totalCoins;
        public void AddCoins(decimal coins)
        {
            _totalCoins = _totalCoins + coins;
        }
    }
}
