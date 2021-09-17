using System;
using System.Text;
using MetalBake.Services;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            string sort;
            Console.WriteLine($@"B | Brownie | 0.65$
M | Mufflin | 1$
C | Cacke Pop | 1.35$
W | Water | 1.50$
Choose a product:");
            sort = Console.ReadLine().ToUpper();
            StockService stockService = new StockService();
        }
            

    }
}
