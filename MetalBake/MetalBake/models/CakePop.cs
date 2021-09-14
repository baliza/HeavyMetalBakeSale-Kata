using MetalBake.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.models
{
    class CakePop : IProduct
    {
        public readonly decimal price = 1.35m;
        public readonly char shortName = 'C';
        public readonly string name = "Cake Pop";
        public int stock = 24;
    }
}
