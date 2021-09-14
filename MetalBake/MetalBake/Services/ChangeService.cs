using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class ChangeService : IChangeable
    {
        private static ChangeService _changeService;

        private ChangeService() {}

        public static ChangeService GetInstance()
        {
            if(_changeService == null)
            {
                _changeService = new ChangeService();
            }
            return _changeService;
        }

        public decimal GetChange(Order order, decimal amount)
        {
            if(amount < order.Total)
            {
                throw new Exception("Not enougth money");
            }
            return order.Total - amount;
        }
    }
}
