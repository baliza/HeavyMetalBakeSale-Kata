using MetalBake.core.Interfaces;
using MetalBake.core.Models;
using MetalBake.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_Bake.Infra.HTTP
{
    public class SoapStockService : IStockService
    {
        WcfStockReference.IService _svc;
        public SoapStockService()
        {
            _svc = new WcfStockReference.ServiceClient();
        }

        public bool CheckStock(string itemId, int amount)
        {
            return _svc.CheckStock(itemId, amount);
        }

        public void ReduceStock(string itemId, int amount)
        {
            _svc.ReduceStock(itemId, amount);
        }
        public int GetStock(string key)
        {
            return _svc.GetStock(key);
        }

        public bool Exist(string item)
        {
            return _svc.Exist(item);
        }

        public List<ItemStock> GetAllStock()
        {
            return _svc.GetAllStock().Select(x=> new ItemStock() { ItemId = x.ItemId, Amount = x.Stock }).ToList();
        }
    }
}
