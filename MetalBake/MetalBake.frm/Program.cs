using MetalBake.frm.Services;
using MetalBake.infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.frm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stockService = new StockService();
            Console.WriteLine(stockService.SetItemStock("W", 3));
            Console.WriteLine(stockService.GetItemStock("W"));
            Console.WriteLine(stockService.SetItemStock("h", 3));
            var restfulPriceService = new RestfulPriceService();
            restfulPriceService.UpdateItemPrice("B", 6);
            var aplication = new Application();
            aplication.MakeAnOrder();
        }
    }
}