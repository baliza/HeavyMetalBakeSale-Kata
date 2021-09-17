using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IPriceService
    {
        decimal GetItemPrice(string itemId);
    }
}