using MetalBandBakery.Core.Domain;
using System;
using System.Collections.Generic;

namespace MetalBandBakery.Core.Services
{
    public interface IStockService
    {
        bool CheckStock(string itemId);

        int GetStock(string item);

        void ReduceStock(string itemId);

        void SetStock(string itemId, int quantity);

        List<OrderLine> GetAllStock();
    }
}