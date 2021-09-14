using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IChangeable
    {
        decimal GetChange(Order order, decimal amount);
    }
}
