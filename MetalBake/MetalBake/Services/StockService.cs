using System;
using System.Collections.Generic;
using System.Text;
using MetalBake.Models;
namespace MetalBake
{
    public class StockService : IStockService
    {
        public  Dictionary<string, int> productsStock = new Dictionary<string, int>()
        {
            {"B",40 },
            {"M",36 },
            {"C",24 },
            {"W",3 }

        };
        Products products = new Products();
        public  void CheckStock(string[] itemId)
        {
            foreach (var item in itemId)
            {
                if (productsStock[item] <= 0)
                {
                    Console.WriteLine($"Not enough stock of {products.productsNames[item]}");
                    System.Environment.Exit(0);//Uso exit para parar aplicacion
                }
                else
                {
                    productsStock[item]--;
                }
            }

        }
    }
}