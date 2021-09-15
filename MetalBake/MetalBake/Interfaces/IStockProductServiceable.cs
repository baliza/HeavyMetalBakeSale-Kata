using MetalBake.Models;
using System.Collections.Generic;

namespace MetalBake.Services
{
    interface IStockProductServiceable
    {
        int GetProductStock(Product product);
        bool AddStock(Product product, int quantity);
        bool IsInStock(Product product, int quantity);
        bool RemoveUnit(Product product);
        bool RemoveUnitMultiple(Product product, int quantity);
    }
}