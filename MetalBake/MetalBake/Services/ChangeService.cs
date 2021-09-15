using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    class ChangeService : IChangeable
    {
        public decimal CalculateChange(decimal coste, decimal pago)
        {
            return pago-coste;
        }
    }
}
