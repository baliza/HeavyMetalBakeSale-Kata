using MetalBandBakery.Console.Services;
using MetalBandBakery.Core.Domain;
using MetalBandBakery.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.Consola
{
    public class Application
    {
        private IPriceService _priceService;
        private IStockService _stockService;

        public Application(IStockService stockService, IPriceService priceService)
        {
            _stockService = stockService;
            _priceService = priceService;
        }

        public void Run()
        {
            var order = new Order();
            order.AddItems(UserIsAskedWhatHeWants());
            ShowPurchasingItems(order);
            if (order.CanBePurchase())
            {
                var amountPaid = AskUserForMoney();
                CalculateChange(order.AmountToPay, amountPaid);
            }
        }

        private decimal AskUserForMoney()
        {
            System.Console.WriteLine("Amount Paid");
            var amountPaid = System.Console.ReadLine();
            return Convert.ToDecimal(amountPaid);
        }

        private void CalculateChange(decimal amountToPay, decimal amountPaid)
        {
            if (!ChangeCalculator.CanBeCalculate(amountPaid, amountToPay))
            {
                System.Console.WriteLine($"You need to put more money");
                return;
            }
            var difference = ChangeCalculator.Calculate(amountPaid, amountToPay);
            System.Console.WriteLine($"your change is: {difference}");
        }

        private void ShowPurchasingItems(Order order)
        {
            foreach (var orderLine in order.OrderLines)
            {
                if (!_stockService.CheckStock(orderLine.ItemId))
                {
                    System.Console.WriteLine("Not enough stock " + orderLine.ItemId);
                    return;
                }
                var itemPrice = _priceService.GetPrice(orderLine.ItemId);
                order.SetPrice(orderLine.ItemId, itemPrice);
                _stockService.ReduceStock(orderLine.ItemId);
            }
            System.Console.WriteLine("Total: " + order.AmountToPay);
        }

        private string[] UserIsAskedWhatHeWants()
        {
            System.Console.WriteLine("Items to Purchase?");
            var items = System.Console.ReadLine().Split(',');
            return items;
        }
    }
}