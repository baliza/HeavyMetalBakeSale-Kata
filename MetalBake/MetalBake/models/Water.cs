using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.models
{
    class Water : Cake
    {
        public Water()
        {
            shortName = 'W';
            name = "Water";
            price = 1.50;
            stock = 30;
        }
    }
}
