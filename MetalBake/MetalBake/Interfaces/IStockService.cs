using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IStockService
    {
        public bool Exist(string item);
        public int GetStock(string key);
        public bool CheckStock(string item, int amount);
        public void ReduceStock(string item, int amount);
        public void PrintStock();
    }
}
