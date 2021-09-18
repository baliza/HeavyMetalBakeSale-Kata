using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class OrderManagerService : IOrderManagerService
    {
        private readonly IStockService _stockService;
        private readonly IPriceService _priceService;
        private readonly IChangeService _changeService;

        public OrderManagerService(IStockService stockService, IPriceService priceService, IChangeService changeService)
        {
            _stockService = stockService;
            _priceService = priceService;
            _changeService = changeService;
        }

        public void MakeAnOrder()
        {
            string[] itemsToBuy = StartOrderProcess();
            Order order = new Order();
            AddItemsInOrder(order, itemsToBuy);
            Console.WriteLine($"Total price is {order.TotalPrice}");
            Console.WriteLine($"How much money do you want to enter?");
            decimal ammountForPay;
            decimal.TryParse(Console.ReadLine(), out ammountForPay);
            GetChange(order.TotalPrice, ammountForPay);
            Console.WriteLine(order.CreateOrderSummary());
        }

        public string[] StartOrderProcess()
        {
            Console.WriteLine(@$"What items do you want to buy?
                        B = Brownie  | $0.65
                        M = Muffin   | $1
                        C = Cake Pop | $1.35
                        W = Water    | $1.5
            ");

            return Console.ReadLine().Split(",");
        }

        public void AddItemsInOrder(Order order, string[] itemsToBuy)
        {
            foreach (var item in itemsToBuy)
            {
                if (GetAndReduceStock(item))
                {
                    order.AddItem(new Item(item), _priceService.GetItemPrice(item));
                }
            }
        }

        public bool GetAndReduceStock(string itemId)
        {
            if (_stockService.GetItemStock(itemId) == -1)
            {
                Console.WriteLine($"There is no stock of the product with identifier of {itemId}");
                return false;
            }
            else
            {
                _stockService.ReduceItemStock(itemId);
                Console.WriteLine($"There are {_stockService.GetItemStock(itemId)} units left of the product with identifier of {itemId}");
                return true;
            }
        }

        public void GetChange(decimal totalPrice, decimal ammountForPay)
        {
            decimal change = _changeService.GetChange(totalPrice, ammountForPay);
            if (change == -1)
            {
                Console.WriteLine("Not enougth money was introduced.");
            }
            else
            {
                Console.WriteLine($"Your change is ${change}");
            }
        }
    }
}