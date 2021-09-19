using MetalBake.Services;
using System;
using Microsoft.Extensions.DependencyInjection;
using MetalBake.Models;
using System.Collections.Generic;
using System.Linq;

namespace MetalBake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            Console.WriteLine(@"HI ROCKSTARS, WELCOME TO PIE-SHOP
    1.- BUY AN ITEM.
    2.- CHECK ITEM STORE.
    3.- EXIT.");

            int option = 0;
            Int32.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 0:
                    Console.WriteLine("IS A WRONG OPTION, PLEASE REWRITE IT");
                    break;

                case 1:
                    CheckItems(inventory);
                    BuyItemByArray(inventory);
                    break;

                case 2:
                    CheckItems(inventory);
                    break;

                case 3:
                    Console.WriteLine("BYE BYE");
                    break;

                default:
                    Console.WriteLine("Thats not an option");
                    break;
            }
        }

        private static void CheckItems(Inventory iService)
        {
            Console.WriteLine(iService);
        }

        private static void BuyItemByArray(Inventory metalInventory)
        {
            Console.WriteLine("Write code of products separated by commas EJ = C,W,B,B,W ");
            string answer = Console.ReadLine();
            string[] newList = answer.Split(',');
            List<Item> itemList = new List<Item>();
            Item item;
            foreach (var code in newList)
            {
                item = metalInventory.checkItemByChar(Char.Parse(code.Trim().ToUpper()));
                if (item != null)
                {
                    if (metalInventory.isOnStock(item))
                    {
                        metalInventory.DelItem(item);
                        itemList.Add(new Item(item.Code, item.Name, 1));
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name} is not in Stock");
                    }
                }
                else
                {
                    Console.WriteLine($"WRONG CODE = {code}");
                }
            }
            Console.WriteLine($"Your list --> \n {string.Join("\n", itemList.Select(e => e.ToString()).ToArray())}");
            double totalPrice = 0;
            foreach (var copyItem in itemList)
            {
                totalPrice += PieMarketService.GetPrice(copyItem);
            }
            Console.WriteLine($"The total price of your cart is: {totalPrice}");
            RepaymentCalculator repaymentCalculator = RepaymentCalculator.GetInstance();
            Console.WriteLine("Introduce your money:");
            double price;
            Double.TryParse(Console.ReadLine(), out price);
            totalPrice = repaymentCalculator.getRepayment(totalPrice, price);
            if (totalPrice == -1)
            {
                Console.WriteLine("Is not enought");
            }
            else
            {
                Console.WriteLine($"${totalPrice} is the repayment");
            }
        }
    }
}