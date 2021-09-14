using MetalBake.models;
using MetalBake.services;
using System;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManagerService ims = new InventoryManagerService(new CakePop(), new Muffin(), new Water(), new Brownie());
            Console.WriteLine("Introduce los productos que quieras comprar");
            string shoppingCart = Console.ReadLine();
            ims.PurchaseItems(shoppingCart);
            ims.PrintStocks();
        }
    }
}
