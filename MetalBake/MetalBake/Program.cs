using System;
using MetalBake.Services;
using MetalBake.Models;
namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = string.Empty;
            while (product != "exit")
            {
                Console.WriteLine(@"Choose a product
                Brownie: B,
                Mufflin:M,
                Cake Pop:C,
                Water: W");
                product = Console.ReadLine().ToUpper();
                var prod = new StockService();
                Products p = prod.GetProductFromKey(product);

            }
            }
    }
}
