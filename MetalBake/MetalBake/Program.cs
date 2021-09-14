using MetalBake.Models;
using MetalBake.Interfaces;
using MetalBake.Services;
using System;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceService priceService = new PriceService();
            StockService stockService = new StockService();
            ChangeService changeService = new ChangeService();

    //        Console.WriteLine(@"Bienvenido a la tienda de pasteles: Seleccione la opción que desea realizar:
    //1-Comprar
    //2-Ver stock
    //3-Ver precios");
    //        var option = Console.ReadLine();

            Console.WriteLine("Items to Purchase?");
            var orderString = Console.ReadLine();
            Order orderList = new Order();
            PriceService priceable = new PriceService();
            var finalOrder = orderList.MakeOrder(orderString);  //pedido completoList <Tuple<char, int>>
            var priceToPay = priceable.CalculateOrderPrice(finalOrder); //precio a pagar del pedido
            //Check si hay stock
            foreach (var item in finalOrder)
            {
                if (!stockService.CheckStock(item.Item1, item.Item2))
                {
                    Console.WriteLine($"Not enough stock of {item}");
                }
            }
            //Respuesta de precio total de la compra
            Console.WriteLine($@"Precio total a pagar: {priceToPay}
Cuanto dinero entregará para pagar:");
            Decimal.TryParse(Console.ReadLine(), out decimal amountPaid);
            if (amountPaid<priceToPay)
            {
                Console.WriteLine("Not enough money paid");
            }
            Console.WriteLine($"Su cambio es: {changeService.CalculateChange(priceToPay, amountPaid)}");
            foreach (var item in finalOrder)
            {
                stockService.ReduceStock(item.Item1, item.Item2);
            }

            //2-Ver stock
            stockService.PrintStock();
            priceService.PrintPrice();
        }
    }
}
