using MetalBake.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.models
{
    internal class Muffin : IProduct
    {
        public char ShortName { get; set; }
        public string Name { get; set; }

        public Muffin()
        {
            ShortName = 'M';
            Name = "Muffin";
        }
    }
}