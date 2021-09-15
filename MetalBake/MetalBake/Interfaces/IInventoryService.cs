using MetalBake.Models;

namespace MetalBake.Services
{
    public interface IInventoryService
    {
        double calculateAmountPrice(double[] priceList, int[] amountList);
        Item checkItemByChar(char code);
    }
}