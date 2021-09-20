using MetalBake.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.infra
{
    public class StockService : IStockService
    {
        public int GetItemStock(string itemId)
        {
            library.WCFStockService.IService wcfService = new library.WCFStockService.ServiceClient();
            return wcfService.GetItemStock(itemId);
        }

        public void ReduceItemStock(string itemId)
        {
            library.WCFStockService.IService wcfService = new library.WCFStockService.ServiceClient();
            wcfService.ReduceItemStock(itemId);
        }
    }
}