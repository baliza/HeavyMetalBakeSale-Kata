using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IPriceable
    {
        decimal GetItemPrice(char key);
    }
}
