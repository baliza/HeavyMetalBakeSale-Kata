using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KataMuffin.Models
{
    public class Stock
    {
        public string Id;
        public string Name;
        public int Amount;

        public Stock(string id, string name, int amount)
        {
            Id = id;
            Name = name;
            Amount = amount;
        }
    }
}