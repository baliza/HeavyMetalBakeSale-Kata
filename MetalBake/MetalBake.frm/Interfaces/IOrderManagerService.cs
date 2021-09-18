using MetalBake.frm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.frm.Interfaces
{
    public interface IOrderManagerService
    {
        void MakeAnOrder();

        string[] StartOrderProcess();

        void AddItemsInOrder(Order order, string[] itemsToBuy);

        bool GetAndReduceStock(string itemId);

        void GetChange(decimal totalPrice, decimal ammountForPay);
    }
}