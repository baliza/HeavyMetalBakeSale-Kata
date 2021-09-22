namespace MetalBandBakery.PriceServicesWebAPI.Repositories
{
    public interface IItemPriceRepository
    {
        ItemPrice Get(string itemId);

        void UpdatePrice(string itemId, decimal quantity);

        System.Collections.Generic.List<ItemPrice> GetAll();
    }
}