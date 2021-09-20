using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
    public interface IOrderable    //Sobraria?
    {
        List<Tuple<char, int>> MakeOrder(string lectura);
    }
}
