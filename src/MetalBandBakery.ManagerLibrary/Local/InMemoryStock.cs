using MetalBandBakery.Core.Domain;
using MetalBandBakery.Core.Services;
using MetalBandBakey.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.ManagerLibrary.Local
{
    public class InMemoryStock : IStockService
    {
        private IStockService stockService;

        public InMemoryStock()
        {
            stockService = new InMemoryStockService();
        }

        public bool CheckStock(string itemId)
        {
            return stockService.CheckStock(itemId);
        }

        public int GetStock(string itemId)
        {
            return stockService.GetStock(itemId);
        }

        public void ReduceStock(string itemId)
        {
            stockService.ReduceStock(itemId);
        }

        public void SetStock(string itemId, int quantity)
        {
            stockService.SetStock(itemId, quantity);
        }

        public List<OrderLine> GetAllStock()
        {
            return stockService.GetAllStock();
        }
    }
}