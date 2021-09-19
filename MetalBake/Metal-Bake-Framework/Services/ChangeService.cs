using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class ChangeService : IChangeService
    {
        //Singleton   **implementarlo**
        private static ChangeService _changeService;
        public ChangeService GetInstance()
        {
            if (_changeService == null)
            {
                _changeService = new ChangeService();
            }
            return _changeService;
        }
        public decimal CalculateChange(decimal coste, decimal pago)
        {
            return pago-coste;
        }
    }
}
