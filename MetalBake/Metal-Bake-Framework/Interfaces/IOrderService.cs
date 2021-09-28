using Metal_Bake_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_Bake_Framework.Interfaces
{
    public interface IOrderService
    {
        Order MakeOrder(List<Tuple<string, int>> order);

        List<string> CompletePurchaseChart(Order order);
    }
}
