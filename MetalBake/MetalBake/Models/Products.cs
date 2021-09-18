using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Products
    {
        public string _Name;
        public string _Id;

        public Products(string name, string id)
        {
            _Name = name;
            _Id = id;
        }
    }
}
