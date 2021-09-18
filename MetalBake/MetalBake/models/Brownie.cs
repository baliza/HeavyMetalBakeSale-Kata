using MetalBake.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.models
{
    internal class Brownie : IProduct
    {
        public char ShortName { get; set; }
        public string Name { get; set; }

        public Brownie()
        {
            ShortName = 'B';
            Name = "Brownie";
        }
    }
}