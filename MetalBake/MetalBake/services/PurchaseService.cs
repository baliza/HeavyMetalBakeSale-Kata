using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.services
{
    class PurchaseService
    {
        private static PurchaseService _instance;
        public decimal Purchase(decimal totalPrice, decimal payed)
        {
            return payed - totalPrice;
        }

        private PurchaseService()
        {

        }

       static public PurchaseService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PurchaseService();
            }
            return _instance;

        }

    }
}
