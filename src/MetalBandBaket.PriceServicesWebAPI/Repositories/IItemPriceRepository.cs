namespace MetalBandBakery.PriceServicesWebAPI.Repositories
{
    public interface IItemPriceRepository
    {
        ItemPrice Get(string itemId);

        //void UpdatePrice(ItemPrice itemPrice);

        System.Collections.Generic.List<ItemPrice> GetAll();
    }
}