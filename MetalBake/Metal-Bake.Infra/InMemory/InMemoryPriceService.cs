using MetalBake.Interfaces;
using MetalBake.Services;
using System;
using System.Collections.Generic;
using static Metal_Bake.Infra.HTTP.RestfullPriceService;

namespace MetalBandBakey.Infra.Repository
{
	public class InMemoryPriceService : IPriceService
	{
		private static Dictionary<string, decimal> _prices;

		public InMemoryPriceService()
		{
			_prices = new Dictionary<string, decimal>() { { "B", 0.65m }, { "M", 1.00m }, { "C", 1.35m }, { "W", 1.50m } };
		}
        public decimal GetPrice(string itemId)
		{
			if (!Exists(itemId))
				return 0m;
			return _prices[itemId];
		}
		private bool Exists(string itemId)
		{
			return _prices.ContainsKey(itemId);
		}
		public decimal CalculateOrderPrice(List<Tuple<string, int>> orderList)
		{
			throw new NotImplementedException();
		}

        public List<PriceService.ItemPrice> GetAllPrices()
        {
			List<PriceService.ItemPrice> listPrices = new List<PriceService.ItemPrice>();
			foreach (var item in _prices)
			{
				listPrices.Add(new PriceService.ItemPrice() { itemId = item.Key, price = item.Value });
			}
			return listPrices;
		}

    }
}
