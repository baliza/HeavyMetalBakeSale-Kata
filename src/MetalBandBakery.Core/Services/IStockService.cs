namespace MetalBandBakery.Core.Services
{
	public interface IStockService
	{
		bool CheckStock(string itemId);

		void ReduceStock(string itemId);
	}
}