using MetalBake.Services;
using System;
using Microsoft.Extensions.DependencyInjection;
using MetalBake.Models;
using System.Collections.Generic;
using System.Linq;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var container = ServiceContainer.Build();
            IInventoryService InventoryService = container.GetService<IInventoryService>();
            IRepaymentCalculator IRepaymentCalculator = container.GetService<IRepaymentCalculator>();*/
            InventoryService inventory = new InventoryService(new Inventory());
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
                    BuyItem(inventory);
                    CheckItems(inventory);
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

        private static void CheckItems(InventoryService iService)
        {
            Console.WriteLine(iService.MetalBakeInventory);
        }

        private static void BuyItem(InventoryService iService)
        {
            Console.WriteLine($"List of items: \n {iService.MetalBakeInventory}");
            string answer = "";
            Item item;
            List<Item> itemList = new List<Item>();
            while(answer != "n")
            {
                Console.WriteLine("Click on code item or click (n) to exit");
                answer = Console.ReadLine();
                if (answer != "n")
                {
                    item = iService.checkItemByChar(Char.Parse(answer));            
                    if (item != null)
                    {
                        if (iService.MetalBakeInventory.isOnStock(item))
                        {
                            iService.DelItem(item);
                            itemList.Add(new Item(item.Code, item.Name, 1, item.Price));
                        }
                        else
                        {
                            Console.WriteLine($"{item.Name} is not in Stock");
                        }
                    }
                    else
                    {
                        Console.WriteLine("WRONG CODE ^^");
                    }
                }      
            }
            Console.WriteLine($"Your list --> \n {string.Join("\n", itemList.Select(e => e.ToString()).ToArray())}");
        }
    }
}
