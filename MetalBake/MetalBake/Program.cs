using MetalBake.Models;
using MetalBake.Services;
using System;
using System.Collections.Generic;

namespace MetalBake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(@$"What items do you want to buy?
                        B = Brownie  | $0.65
                        M = Muffin   | $1
                        C = Cake Pop | $1.35
                        W = Water    | $1.5
            ");
            List<Item> purchaseItems = new List<Item>();
            Order order = new Order(PurchaseItems);
            PriceService priceService = new PriceService();
            StockService stockService = new StockService();
            ChangeService changeService = ChangeService.GetInstance();

            try
            {
                string Items = Console.ReadLine();
                String[] StringKeys = Items.Split(",");

                foreach (var key in StringKeys)
                {
                    var keyChar = Char.Parse(key);
                    // compruebo si hay stock
                    checkeoQueHayStock(stockService, keyChar);
                    // Devuelvo el precio del item
                    var itemPrice = priceService.GetItemPrice(keyChar);
                    // Creo un item y lo añado a la orden
                    Item item = ItemsFactory.CreateItem(keyChar);
                    purchaseItems.Add(item);
                    // Resto 1 del stock
                    stockService.ReduceItemStock(keyChar);
                    // Precio total de la compra
                    order.TotalPrice += itemPrice;
                }
                order.BuyItemsList = purchaseItems;
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

        private static void checkeoQueHayStock(StockService stockService, char keyChar)
        {
            stockService.GetItemStock(keyChar);
        }
    }
}