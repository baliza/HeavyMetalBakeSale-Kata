﻿namespace MetalBandBakery.Core.Domain
{
    public class OrderLine
    {
        public OrderLine(string itemId)
        {
            ItemId = itemId;
            Amount = 1;
        }

        public int Amount { get; set; }
        public decimal BasePrice { get; set; }
        public string ItemId { get; private set; }
        public decimal TotalPrice { get { return Amount * BasePrice; } }

        public void IncresaseAmount()
        {
            Amount++;
        }
    }
}