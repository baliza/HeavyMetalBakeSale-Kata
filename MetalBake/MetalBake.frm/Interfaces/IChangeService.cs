using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.frm.Interfaces
{
    public interface IChangeService
    {
        decimal GetChange(decimal totalPrice, decimal amountForPay);
    }
}