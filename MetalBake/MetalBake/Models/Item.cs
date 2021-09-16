using MetalBake.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Item
    {
        public char Code;
        public string Name;
        public int Amount;

        public Item(char code,string name, int amount)
        {
            Code = code;
            Name = name;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Code: {Code} - Name: {Name} - Amount: {Amount} - Price: {PieMarketService.GetPrice(this)}";
        }
    }
}
