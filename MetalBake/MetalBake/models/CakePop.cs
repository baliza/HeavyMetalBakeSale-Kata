using MetalBake.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.models
{
    internal class CakePop : IProduct
    {
        public CakePop()
        {
            ShortName = 'C';
            Name = "Cake Pop";
        }

        public char ShortName { get; set; }
        public string Name { get; set; }
    }
}