using MetalBandBakery.Core.Domain;
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

        public void SetStock(string itemId, int quantity)
        {
            if (Exists(itemId))
                _stock[itemId] = quantity;
        }

        public bool CheckStock(string itemId)
        {
            if (!Exists(itemId))
                return false;
            return _stock[itemId] > 0;
        }

        public List<OrderLine> GetAllStock()
        {
            List<OrderLine> orderList = new List<OrderLine>();
            OrderLine oLine;
            foreach (var stockItem in _stock)
            {
                oLine = new OrderLine(stockItem.Key);
                oLine.Amount = stockItem.Value;
                orderList.Add(oLine);
            }
            return orderList;
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