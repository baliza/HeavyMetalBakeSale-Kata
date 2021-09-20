using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.core.Services
{
    public interface IStockService
    {
        int GetItemStock(string itemId);

        void ReduceItemStock(string itemId);
    }
}