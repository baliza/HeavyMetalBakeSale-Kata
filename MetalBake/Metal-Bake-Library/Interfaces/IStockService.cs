using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    interface IStockService
    {
        bool Exist(char item);
        int GetStock(char key);
        bool CheckStock(char item, int amount);
        void ReduceStock(char item, int amount);
        void PrintStock();
    }
}
