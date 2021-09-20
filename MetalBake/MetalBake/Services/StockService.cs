using System;
using System.Collections.Generic;
using System.Text;
namespace MetalBake
{
    public class StockService : IStockService
    {
        public static Dictionary<string, int> productsStock = new Dictionary<string, int>()
        {
            {"B",40 },
            {"M",36 },
            {"C",24 },
            {"W",3 }

        };
        public static Dictionary<string, string> productsNames = new Dictionary<string, string>()
        {
            {"B","Brownie" },
            {"M","Mofflin" },
            {"C","Cake Pop" },
            {"W","Water" }
        };
        public  void CheckStock(string[] itemId)
        {
            foreach (var item in itemId)
            {
                if (productsStock[item] <= 0)
                {
                    Console.WriteLine($"Not enough stock of {productsNames[item]}");
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