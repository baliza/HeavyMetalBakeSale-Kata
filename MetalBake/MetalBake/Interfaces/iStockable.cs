﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Interfaces
{
     public interface IStockable
    {
        void CheckItemStock(char key);
        void ReduceItemStock(char key);
    }
}
