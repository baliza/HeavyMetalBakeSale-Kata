using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class ChangeService : IChangeService
    {
        private static ChangeService _changeService;

        private ChangeService()
        {
        }

        public static ChangeService GetInstance()
        {
            if (_changeService == null)
            {
                _changeService = new ChangeService();
            }
            return _changeService;
        }

        public decimal GetChange(Order order, decimal amount)
        {
            if (amount < order.TotalPrice)
            {
                Console.WriteLine("Not enougth money");
                return -1;
            }
            return amount - order.TotalPrice;
        }
    }
}