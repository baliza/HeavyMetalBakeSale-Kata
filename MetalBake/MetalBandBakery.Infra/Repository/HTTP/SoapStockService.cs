using MetalBandBakery.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.Infra.Repository.HTTP
{
    public class SoapStockService : IStockService
    {
        public bool CheckStock(string itemId)
        {
            WCFStockService.IService svc = new WCFStockService.ServiceClient();
            return svc.CheckStock(itemId) > 0;
        }

        public void ReduceStock(string itemId)
        {
            WCFStockService.IService svc = new WCFStockService.ServiceClient();
            svc.ReduceStock(itemId);
        }
    }
}