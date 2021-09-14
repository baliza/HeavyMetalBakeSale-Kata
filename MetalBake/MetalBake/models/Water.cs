using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.models
{
    class Water : IProduct
    {
        public readonly double price = 1.50;
        public readonly char shortName = 'W';
        public readonly string name = "Water";
        public int stock = 30;
       
    }
}
