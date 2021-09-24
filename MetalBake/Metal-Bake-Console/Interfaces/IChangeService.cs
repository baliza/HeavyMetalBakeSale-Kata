using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IChangeService
    {
        decimal CalculateChange(decimal coste, decimal pago);
    }
}
