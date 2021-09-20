using System.Collections.Generic;
using System.Linq;

namespace MetalBandBakery.PriceServicesWebAPI.Repositories
{
	public class ItemPriceRepository : IItemPriceRepository
	{
		private static Dictionary<string, decimal> _prices;

		static ItemPriceRepository()
		{
			_prices = new Dictionary<string, decimal>() { { "B", 0.65m }, { "M", 1.00m }, { "C", 1.35m }, { "W", 1.50m } };
		}

		public ItemPrice Get(string itemId)
		{
			if (!Exists(itemId))
				return null;
			return new ItemPrice
			{
				ItemId = itemId,
				Price = _prices[itemId]
			};
		}

		public List<ItemPrice> GetAll()
		{
			return _prices.Select(x => new ItemPrice
			{
				ItemId = x.Key,
				Price = x.Value
			}).ToList();
		}

		private bool Exists(string itemId)
		{
			return _prices.ContainsKey(itemId);
		}
	}
}