﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetalBakeMVC.Models
{
    public class ItemPrice
    {
        public string ItemId { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}