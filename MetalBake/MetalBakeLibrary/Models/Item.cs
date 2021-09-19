using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MetalBakeLibrary
{
    [DataContract]
    public class Item
    {
        [DataMember]
        public char Code;

        [DataMember]
        public string Name;

        [DataMember]
        public int Amount;

        public Item(char code, string name, int amount)
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