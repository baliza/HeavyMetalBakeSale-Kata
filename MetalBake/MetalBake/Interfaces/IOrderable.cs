﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IOrderable    //Sobraria?
    {
        public List<Tuple<string, int>> MakeOrder(string lectura);
    }
}
