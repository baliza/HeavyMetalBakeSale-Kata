using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IStockService
    {
        int GetItemStock(string itemId);

        void ReduceItemStock(string itemId);
    }
}