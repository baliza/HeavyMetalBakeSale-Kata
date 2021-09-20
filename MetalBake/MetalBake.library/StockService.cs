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
        private library.WCFStockService.IService _wcfService;

        public StockService()
        {
            _wcfService = new library.WCFStockService.ServiceClient();
        }

        public int GetItemStock(string itemId)
        {
            return _wcfService.GetItemStock(itemId);
        }

        public void ReduceItemStock(string itemId)
        {
            _wcfService.ReduceItemStock(itemId);
        }
    }
}