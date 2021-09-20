namespace MetalBandBakery
{
    public class OrderLine
    {
        public OrderLine(string itemId)
        {
            ItemId = itemId;
            Amount = 1;
        }

        public string ItemId { get; private set; }
        public int Amount { get; private set; }
        public decimal BasePrice { get; set; }
        public decimal TotalPrice { get { return Amount * BasePrice; } }

        public void IncresaseAmount()
        {
            Amount++;
        }
    }
}