using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.models
{
    class Muffin : IProduct
    {
        public readonly double price = 1;
        public readonly char shortName = 'M';
        public readonly string name = "Muffin";
        public int stock = 36;
        
    }
}
