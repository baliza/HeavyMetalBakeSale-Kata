using MetalBake.Models;

namespace MetalBake.Services
{
    public interface IStockService
    {
        void AddStock(Products product);
        Products GetProductFromKey(string key);
        bool IsInStock(Products product);
        void ReduceStock(Products product);
    }
}