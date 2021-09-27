using MetalBandBakery.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.Infra.Repository.InMemory
{
    public class InMemoryStockService : IStockService
    {
        private Dictionary<string, int> _stock;

        public InMemoryStockService()
        {
            _stock = new Dictionary<string, int>() { { "B", 30 }, { "M", 36 }, { "C", 24 }, { "W", 0 } };
        }

        public bool CheckStock(string itemId)
        {
            if (!Exists(itemId))
                return false;
            return _stock[itemId] > 0;
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