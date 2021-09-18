using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.interfaces
{
    internal interface IProduct
    {
        char ShortName { get; set; }
        string Name { get; set; }
    }
}