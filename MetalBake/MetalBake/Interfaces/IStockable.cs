using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    interface IStockable
    {
        public bool Exist(char item);
        public int GetStock(char key);
        public bool CheckStock(char item, int amount);
        public void ReduceStock(char item, int amount);
        public void PrintStock();
    }
}
