using MetalBake.Models;
using MetalBake.Services;
using System;
using System.Collections.Generic;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What items do you want to buy?");
            List<Item> PurchaseItems = new List<Item>();
            Order order = new Order(PurchaseItems);
            PriceService priceService = new PriceService();
            StockService stockService = new StockService();
            ChangeService changeService = ChangeService.GetInstance();

            try
            {
                string Items;
                Items = Console.ReadLine();
                String[] StringKeys = Items.Split(",");

                foreach (var key in StringKeys)
                {
                    var keyChar = Char.Parse(key);
                    // compruebo si hay stock
                    stockService.CheckItemStock(keyChar);
                    // Devuelvo el precio del item
                    var itemPrice = priceService.GetItemPrice(keyChar);

                    // A la orden le añado el nuevo item
                    order.BuyItemsList.Add(new Item("", keyChar));
                    // Resto 1 del stock
                    stockService.ReduceItemStock(keyChar);
                    // Precio total de la compra
                    order.TotalPrice += itemPrice;
                }
                Console.WriteLine($"Total price is {order.TotalPrice}");
                Console.WriteLine($"How much money do you want to enter?");

                decimal amount;

                decimal.TryParse(Console.ReadLine(), out amount);
                Console.WriteLine($"Your change is ${changeService.GetChange(order, amount)}");

            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
            


        }
    }
}
