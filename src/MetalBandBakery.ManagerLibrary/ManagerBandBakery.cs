using MetalBandBakery.Core.Domain;
using MetalBandBakery.Core.Services;
using MetalBandBakey.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.ManagerLibrary
{
    public class ManagerBandBakery
    {
        private IStockService _stockService;
        private IPriceService _priceService;
        private IStockService _memoryStockService;

        public ManagerBandBakery()
        {
            _stockService = new SoapStockService();
            _priceService = new RestfullPriceService();
            _memoryStockService = new InMemoryStockService();
        }

        public bool CheckStock(string itemId)
        {
            return _stockService.CheckStock(itemId);
        }

        public int GetStock(string itemId)
        {
            return _stockService.GetStock(itemId);
        }

        public void ReduceStock(string itemId)
        {
            _stockService.ReduceStock(itemId);
        }

        public void SetStock(string itemId, int quantity)
        {
            _stockService.SetStock(itemId, quantity);
        }

        public List<OrderLine> GetAllStock()
        {
            return _stockService.GetAllStock();
        }

        public IEnumerable<Recipe> GetAllRepices()
        {
            return _priceService.GetAllRepices();
        }

        public decimal GetPrice(string itemId)
        {
            return _priceService.GetPrice(itemId);
        }

        public Recipe GetRepice(string itemId)
        {
            return _priceService.GetRepice(itemId);
        }

        public void UpdateRecipe(string itemId, Dictionary<string, int> ingredients, decimal extra)
        {
            _priceService.UpdateRecipe(itemId, ingredients, extra);
        }

        // Memory
        public bool MemoryCheckStock(string itemId)
        {
            return _memoryStockService.CheckStock(itemId);
        }

        public int MemoryGetStock(string itemId)
        {
            return _memoryStockService.GetStock(itemId);
        }

        public void MemoryReduceStock(string itemId)
        {
            _memoryStockService.ReduceStock(itemId);
        }

        public void MemorySetStock(string itemId, int quantity)
        {
            _memoryStockService.SetStock(itemId, quantity);
        }

        public List<OrderLine> MemoryGetAllStock()
        {
            return _memoryStockService.GetAllStock();
        }
    }
}