using System;

namespace MetalBandBakery.Core.Services
{
    public interface IStockService
    {
        bool CheckStock(string itemId);

        int GetStock(string item);

        void ReduceStock(string itemId);

        void AddStock(string itemId, int quantity);
    }
}