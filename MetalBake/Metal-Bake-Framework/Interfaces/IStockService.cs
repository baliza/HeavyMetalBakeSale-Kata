using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IStockService
    {
        bool Exist(string item);
        int GetStock(string key);
        bool CheckStock(string item, int amount);
        void ReduceStock(string item, int amount);
        Dictionary<string, int> GetAllStock();
    }
}
