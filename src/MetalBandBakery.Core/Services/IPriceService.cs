namespace MetalBandBakery.Core.Services
{
	public interface IPriceService
	{
		decimal GetPrice(string itemId);

		void UpdatePrice(string itemId, decimal newPrice);
	}
}