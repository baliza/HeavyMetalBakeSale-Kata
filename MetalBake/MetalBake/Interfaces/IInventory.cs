namespace MetalBake.Models
{
    public interface IInventory
    {
        double calculateAmountPrice(double[] priceList, int[] amountList);
        Item checkItemByChar(char code);
        void DelItem(Item item);
        bool isOnStock(Item item);
        string ToString();
    }
}