using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Item
    {
        public char Code;
        public string Name;
        public double Price;
        public int Amount;


        public Item(char code,string name, double price, int amount)
        {
            Code = code;
            Name = name;
            Price = price;
            Amount = amount;
        }
    }
}
