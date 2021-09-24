using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IInventoryRepository
    {
        bool Exist(string item);
        int GetStock(string key);
        bool CheckStock(string item, int amount);
        void ReduceStock(string item, int amount);
        void IncreaseStock(string item, int amount);
        bool SetItemStock(string itemId, int cuantity);
        List<ItemStock> GetAllStock();
    }
}
