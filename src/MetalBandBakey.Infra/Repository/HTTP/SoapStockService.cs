using MetalBandBakery.Core.Services;
using MetalBandBakey.Infra.WCFStockService;
using System;

namespace MetalBandBakey.Infra.Repository
{
    public class SoapStockService : IStockService
    {
        public void AddStock(string itemId, int quantity)
        {
            IService svc = new ServiceClient();
            svc.AddStock(itemId, quantity);
        }

        public bool CheckStock(string itemId)
        {
            IService svc = new ServiceClient();
            return svc.CheckStock(itemId) > 0;
        }

        public int GetStock(string itemId)
        {
            IService svc = new ServiceClient();
            return svc.CheckStock(itemId);
        }

        public void ReduceStock(string itemId)
        {
            IService svc = new ServiceClient();
            svc.ReduceStock(itemId);
        }
    }
}