namespace MetalBandBakery.PriceServicesWebAPI.Repositories
{
	public interface IItemPriceRepository
	{
		ItemPrice Get(string itemId);

		System.Collections.Generic.List<ItemPrice> GetAll();
	}
}