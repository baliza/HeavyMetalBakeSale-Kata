using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.models
{
    class Brownie : IProduct
    {
        public readonly double price = 0.65;
        public readonly char shortName = 'B';
        public readonly string name = "Brownie";
        public int stock = 40;
    }
}
