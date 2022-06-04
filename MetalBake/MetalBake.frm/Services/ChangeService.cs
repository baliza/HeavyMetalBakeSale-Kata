using MetalBake.frm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.frm.Services
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