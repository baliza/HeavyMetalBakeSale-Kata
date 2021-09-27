using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.Core.Services
{
    public interface IStockService
    {
        bool CheckStock(string itemId);

        void ReduceStock(string itemId);
    }
}