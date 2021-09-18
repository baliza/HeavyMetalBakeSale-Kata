using System;
using System.Collections.Generic;
using System.Text;
using MetalBake.Services;
using MetalBake.Models;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            List<string> keys = new List<string>();
            Console.WriteLine(   $@"B | Brownie | 0.65$
                                    M | Mufflin | 1$
                                    C | Cacke Pop | 1.35$
                                    W | Water | 1.50$
                                    Choose products:");
            StockService stockService = new StockService();
            PriceService priceService = new PriceService();
            Order neworder = new Order();
            string k = Console.ReadLine().ToUpper();
            k = String.Join<char>(",", k);//Añade coma a la cadena que introduzcas para pasar a la lista


        }
            

    }
}
