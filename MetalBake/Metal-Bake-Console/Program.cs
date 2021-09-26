using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel;
using MetalBake.core.Interfaces;
using Metal_Bake_Console;
using MetalBake.Interfaces;

namespace Metal
{

    class Program
    {
        /*static void Main(string[] args)
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

            //private static IStockService _wcfStockService = new SoapStockService();
            //private static IPriceService _rfPriceService = new RestfullPriceService();
            //private static IStockService _stockService = new InMemoryStockService();
            //private static IPriceService _priceService = new InMemoryPriceService();



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
                        var purchase = new Purchase(itemService, stockService, priceService, orderService, changeService);
                        purchase.PurchaseOption();
                        break;
                    case "2":
                        itemService.PrintItemList();
                        break;
                    case "3": break;
                }
                Console.WriteLine(Environment.NewLine);
            } while (!option.Equals("3"));
        }*/
    }

}
