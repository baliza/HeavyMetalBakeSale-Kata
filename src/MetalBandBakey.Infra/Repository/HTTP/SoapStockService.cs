using MetalBandBakery.Core.Domain;
using MetalBandBakery.Core.Services;
using WCFStock = MetalBandBakey.Infra.WCFStockService;
using System;
using System.Collections.Generic;

namespace MetalBandBakey.Infra.Repository
{
    public class SoapStockService : IStockService
    {
        public void SetStock(string itemId, int quantity)
        {
            WCFStock.IService svc = new WCFStock.ServiceClient();
            svc.SetStock(itemId, quantity);
        }

        public bool CheckStock(string itemId)
        {
            WCFStock.IService svc = new WCFStock.ServiceClient();
            return svc.CheckStock(itemId) > 0;
        }

        public List<OrderLine> GetAllStock()
        {
            List<OrderLine> orderList = new List<OrderLine>();
            WCFStock.IService svc = new WCFStock.ServiceClient();
            var itemCloud = svc.GetAllStock();
            OrderLine itemCore;
            foreach (var i in itemCloud)
            {
                itemCore = new OrderLine(i.ItemId);
                itemCore.Amount = i.Quantity;
                orderList.Add(itemCore);
            }
            return orderList;
        }

        public int GetStock(string itemId)
        {
            WCFStock.IService svc = new WCFStock.ServiceClient();
            return svc.CheckStock(itemId);
        }

        public void ReduceStock(string itemId)
        {
            WCFStock.IService svc = new WCFStock.ServiceClient();
            svc.ReduceStock(itemId);
        }
    }
}