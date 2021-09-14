using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    interface IChangeable
    {
        decimal CalculateChange(decimal coste, decimal pago);
    }
}
