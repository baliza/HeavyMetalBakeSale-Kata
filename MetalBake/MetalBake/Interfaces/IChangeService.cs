using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IChangeService
    {
        decimal GetChange(Order order, decimal amount);
    }
}