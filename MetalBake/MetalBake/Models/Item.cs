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
        public double Price;
        public int Amount;


        public Item(char code,string name, int amount, double price = 0)
        {
            Code = code;
            Name = name;
            if (price == 0)
            {
                Price = PieMarketService.GenerateNewPrice();
            }
            else
            {
                Price = price;
            }
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Code: {Code} - Name: {Name} - Price: {Price} - Amount: {Amount}";
        }
    }
}
