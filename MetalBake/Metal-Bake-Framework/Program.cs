using MetalBake.Models;
using MetalBake.Interfaces;
using MetalBake.Services;
using Microsoft.Extensions.DependencyInjection;

using System;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            //PriceService priceService = new PriceService();
            //StockService stockService = new StockService();
            //ChangeService changeService = ChangeService.GetInstance();
            //ItemService itemService = new ItemService();
            //OrderService orderService = new OrderService();

            var containerProvider = Container.Build();
            var itemService = containerProvider.GetService<IItemService>();
            var orderService = containerProvider.GetService<IOrderable>();
            var stockService = containerProvider.GetService<IStockService>();
            var priceService = containerProvider.GetService<IPriceService>();
            var changeService = containerProvider.GetService<IChangeService>();
            var option = "0";
            do
            {
                Console.WriteLine(@"Bienvenido a la tienda de pasteles: Seleccione la opción que desea realizar:
    1-Comprar
    2-Ver lista de productos
    3-Terminar");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":                        
                        Console.WriteLine("Items to Purchase?");
                        itemService.PrintItemList();
                        var orderString = Console.ReadLine();
                        var finalOrder = orderService.MakeOrder(orderString);
                        bool allStock = true;
                        foreach (var item in finalOrder)
                        {
                            if (!stockService.CheckStock(item.Item1, item.Item2))
                            {
                                Console.WriteLine($"Not enough stock of {item.Item1}, only {stockService.GetStock(item.Item1)} left");
                                allStock = false;
                            }
                        }
                        if (!allStock)
                        {
                            break;
                        }
                        var priceToPay = priceService.CalculateOrderPrice(finalOrder);
                        Console.WriteLine($@"Precio total a pagar: {priceToPay}
Cuanto dinero entregará para pagar:");
                        Decimal.TryParse(Console.ReadLine(), out decimal amountPaid);
                        if (amountPaid < priceToPay)
                        {
                            Console.WriteLine("Not enough money paid");
                            break;
                        }
                        Console.WriteLine($"Su cambio es: {changeService.CalculateChange(priceToPay, amountPaid)}");
                        foreach (var item in finalOrder)
                        {
                            stockService.ReduceStock(item.Item1, item.Item2);
                        }
                        break;
                    case "2":
                        itemService.PrintItemList();
                        break;
                    case "3": break;
                }
                Console.WriteLine(Environment.NewLine);
            } while (!option.Equals("3"));
        }
    }
}
