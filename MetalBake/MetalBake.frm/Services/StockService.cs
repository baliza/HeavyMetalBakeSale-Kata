using MetalBake.frm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.frm.Services
{
    public class StockService : IStockService
    {
        private Dictionary<string, int> _itemsStock = new Dictionary<string, int>
        {
            {"B", 40 },
            {"M", 36},
            {"C", 24 },
            {"W", 0 }
        };

        public int GetItemStock(string itemId)
        {
            if (_itemsStock[itemId] <= 0)
            {
                return -1;
            }
            return _itemsStock[itemId];
        }

        public void ReduceItemStock(string itemId)
        {
            _itemsStock[itemId] -= 1;
        }
    }
}