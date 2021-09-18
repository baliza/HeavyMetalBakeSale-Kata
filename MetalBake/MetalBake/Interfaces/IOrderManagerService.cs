using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
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