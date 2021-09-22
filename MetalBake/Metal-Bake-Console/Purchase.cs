using MetalBake.Models;
using MetalBake.Interfaces;
using MetalBake.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MetalBake
{
    public class Purchase
    {
        private IItemService _itemService;
        private IStockService _stockService;
        private IPriceService _priceService;
        private IOrderable _orderService;
        private IChangeService _changeService;

        public Purchase(IItemService itemService, IStockService stockService, IPriceService priceService,
            IOrderable orderService, IChangeService changeService)
        {
            _itemService = itemService;
            _stockService = stockService;
            _priceService = priceService;
            _orderService = orderService;
            _changeService = changeService;
        }

        public void PurchaseOption()
        {
            //var containerProvider = Container.Build();
            //var itemService = containerProvider.GetService<IItemService>();
            //var orderService = containerProvider.GetService<IOrderable>();
            //var stockService = containerProvider.GetService<IStockService>();
            //var priceService = containerProvider.GetService<IPriceService>();
            //var changeService = containerProvider.GetService<IChangeService>();

            Console.WriteLine("Items to Purchase?");
            _itemService.PrintItemList();
            var orderString = Console.ReadLine();
            var finalOrder = _orderService.MakeOrder(orderString);
            bool allStock = true;
            foreach (var item in finalOrder)
            {
                if (!_stockService.CheckStock(item.Item1, item.Item2))
                {
                    Console.WriteLine($"Not enough stock of {item.Item1}, only {_stockService.GetStock(item.Item1)} left");
                    allStock = false;
                }
            }
            if (!allStock)
            {
                return;
            }
            var priceToPay = _priceService.CalculateOrderPrice(finalOrder);
            Console.WriteLine($@"Precio total a pagar: {priceToPay}
Cuanto dinero entregará para pagar:");
            Decimal.TryParse(Console.ReadLine(), out decimal amountPaid);
            if (amountPaid < priceToPay)
            {
                Console.WriteLine("Not enough money paid");
                return;
            }
            Console.WriteLine($"Su cambio es: {_changeService.CalculateChange(priceToPay, amountPaid)}");
            foreach (var item in finalOrder)
            {
                _stockService.ReduceStock(item.Item1, item.Item2);
            }
        }
    }
}

