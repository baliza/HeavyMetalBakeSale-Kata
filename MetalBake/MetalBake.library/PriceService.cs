using MetalBake.core.Models;
using MetalBake.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.infra
{
    public class PriceService : IPriceService
    {
        public List<ItemPrice> GetAllPrices()
        {
            throw new NotImplementedException();
        }

        public decimal GetItemPrice(string itemId)
        {
            library.WCFPriceService.IService wcfPriceService = new library.WCFPriceService.ServiceClient();
            return wcfPriceService.GetItemPrice(itemId);
        }

        public bool UpdateItemPrice(string itemId, decimal newPrice)
        {
            throw new NotImplementedException();
        }
    }
}