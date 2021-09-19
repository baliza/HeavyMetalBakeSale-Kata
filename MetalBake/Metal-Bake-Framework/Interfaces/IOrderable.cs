using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    interface IOrderable    //Sobraria?
    {
        public List<Tuple<char, int>> MakeOrder(string lectura);
    }
}
