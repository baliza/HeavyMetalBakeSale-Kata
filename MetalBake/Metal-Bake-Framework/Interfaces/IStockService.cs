using MetalBake.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.core.Interfaces
{
    public interface IStockService
    {
        bool Exist(string item);
        int GetStock(string key);
        bool CheckStock(string item, int amount);
        void ReduceStock(string item, int amount);
        List<ItemStock> GetAllStock();
    }
}
