using MetalBake.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.core.Services
{
    public interface IPriceService
    {
        decimal GetItemPrice(string itemId);

        List<ItemPrice> GetAllPrices();

        bool UpdateItemPrice(string itemId, decimal newPrice);
    }
}