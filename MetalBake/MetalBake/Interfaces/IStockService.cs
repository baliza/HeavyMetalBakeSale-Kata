using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IStockService
    {
        int GetItemStock(char key);

        void CheckItemStock(char key);

        void ReduceItemStock(char key);
    }
}