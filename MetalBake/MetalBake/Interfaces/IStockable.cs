using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    interface IStockable
    {
        bool Exist(char item);
        bool CheckStock(char item, int amount);
        void ReduceStock(char item, int amount);
    }
}
