using MetalBandBakery.Core.Services;
using MetalBandBakery.Infra.Repository.HTTP;
using MetalBandBakery.Infra.Repository.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.Consola
{
    internal class Program
    {
        private static IStockService _wcfStockService = new SoapStockService();
        private static IPriceService _rfPriceService = new RestfullPriceService();
        private static IStockService _stockService = new InMemoryStockService();
        private static IPriceService _priceService = new InMemoryPriceService();

        private static void Main(string[] args)
        {
            var application = new Application(_wcfStockService, _rfPriceService);
            application.Run();
        }
    }
}