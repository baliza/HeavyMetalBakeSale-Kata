using MetalBandBakery.Core.Services;
using System;
using System.Collections.Generic;

namespace MetalBandBakey.Infra.Repository
{
    public class InMemoryStockService : IStockService
    {
        private Dictionary<string, int> _stock;

        public InMemoryStockService()
        {
            _stock = new Dictionary<string, int>() { { "B", 30 }, { "M", 36 }, { "C", 24 }, { "W", 0 } };
        }

        public void AddStock(string itemId, int quantity)
        {
            if (Exists(itemId))
                _stock[itemId] += quantity;
        }

        public bool CheckStock(string itemId)
        {
            if (!Exists(itemId))
                return false;
            return _stock[itemId] > 0;
        }

        public int GetStock(string itemId)
        {
            if (!Exists(itemId))
                return -1;
            return _stock[itemId];
        }

        public void ReduceStock(string itemId)
        {
            if (Exists(itemId))
                _stock[itemId]--;
        }

        private bool Exists(string itemId)
        {
            return _stock.ContainsKey(itemId);
        }
    }
}