using MetalBandBakery.Core.Domain;
using MetalBandBakery.Core.Services;
using MetalBandBakery.Services;
using System;

namespace MetalBandBakery
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
            openAdminTools();
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
            Console.WriteLine("Amount Paid");
            var amountPaid = Console.ReadLine();
            return Convert.ToDecimal(amountPaid);
        }

        private void CalculateChange(decimal amountToPay, decimal amountPaid)
        {
            if (!ChangeCalculator.CanBeCalculate(amountPaid, amountToPay))
            {
                Console.WriteLine($"You need to put more money");
                return;
            }
            var difference = ChangeCalculator.Calculate(amountPaid, amountToPay);
            Console.WriteLine($"your change is: {difference}");
        }

        private void ShowPurchasingItems(Order order)
        {
            foreach (var orderLine in order.OrderLines)
            {
                if (!_stockService.CheckStock(orderLine.ItemId))
                {
                    Console.WriteLine("Not enough stock " + orderLine.ItemId);
                    return;
                }
                var itemPrice = _priceService.GetPrice(orderLine.ItemId);
                order.SetPrice(orderLine.ItemId, itemPrice);
                _stockService.ReduceStock(orderLine.ItemId);
            }
            Console.WriteLine("Total: " + order.AmountToPay);
        }

        private void openAdminTools()
        {
            Console.WriteLine(@"What do u want?
    1.- Add item stock.
    2.- Change item price.
    3.- Nothing.");
            int option = 3;

            Int32.TryParse(Console.ReadLine(), out option);

            if (option == 1)
            {
                Tuple<string, int> tuple = AdminNewStock();
                Console.WriteLine($"BEFORE: Item with code {tuple.Item1} has {_stockService.GetStock(tuple.Item1)} units.");
                _stockService.SetStock(tuple.Item1, tuple.Item2);
                Console.WriteLine($"NOW: Item with code {tuple.Item1} has {_stockService.GetStock(tuple.Item1)} units.");
            }
            else if (option == 2)
            {
                Tuple<string, int> tuple = AdminNewPrice();
                Console.WriteLine($"BEFORE: Item with code {tuple.Item1} - ${_priceService.GetPrice(tuple.Item1)}");
                //_priceService.UpdatePrice(tuple.Item1, tuple.Item2);
                Console.WriteLine($"AFTER: Item with code {tuple.Item1} - ${_priceService.GetPrice(tuple.Item1)}");
            }
        }

        private Tuple<string, int> AdminNewStock()
        {
            Console.WriteLine("Item to add stock?");
            string itemId = Console.ReadLine().Substring(0, 1);
            int itemQuantity = 0;
            Console.WriteLine("Quantity to add stock?");
            int.TryParse(Console.ReadLine(), out itemQuantity);
            Tuple<String, int> itemToAdd = new Tuple<string, int>(itemId, itemQuantity);

            return itemToAdd;
        }

        private Tuple<string, int> AdminNewPrice()
        {
            Console.WriteLine("Item to edit price?");
            string itemId = Console.ReadLine().Substring(0, 1);
            int itemQuantity = 0;
            Console.WriteLine($"New price to {itemId}?");
            int.TryParse(Console.ReadLine(), out itemQuantity);
            Tuple<String, int> itemToAdd = new Tuple<string, int>(itemId, itemQuantity);

            return itemToAdd;
        }

        private string[] UserIsAskedWhatHeWants()
        {
            Console.WriteLine("Items to Purchase?");
            var items = Console.ReadLine().Split(',');
            return items;
        }
    }
}