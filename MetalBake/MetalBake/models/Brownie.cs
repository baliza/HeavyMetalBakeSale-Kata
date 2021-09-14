using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.models
{
    class Brownie : Cake
    {
        public Brownie ()
        {
            shortName = 'B';
            name = "Brownie";
            price = 0.65;
            stock = 40;
        }
    }
}
