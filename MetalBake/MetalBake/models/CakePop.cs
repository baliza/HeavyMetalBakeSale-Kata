using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.models
{
    class CakePop : IProduct
    {
        public readonly double price = 1.35;
        public readonly char shortName = 'C';
        public readonly string name = "Cake Pop";
        public int stock = 24;
    }
}
