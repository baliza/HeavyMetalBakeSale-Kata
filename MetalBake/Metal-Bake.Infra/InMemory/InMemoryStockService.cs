using MetalBake.Interfaces;
using System.Collections.Generic;

namespace MetalBandBakey.Infra.Repository
{
	public class InMemoryStockService : IStockService
	{
		private Dictionary<string, int> _inventory;

		public InMemoryStockService()
		{
			_inventory = new Dictionary<string, int>() { { "B", 30 }, { "M", 36 }, { "C", 24 }, { "W", 0 } };
		}

		public bool CheckStock(string itemId, int amount)
		{
			if (!Exist(itemId))
				return false;
			return _inventory[itemId] > 0;
		}

		public void ReduceStock(string itemId, int amount)
		{
			if (Exist(itemId))
				_inventory[itemId]--;
		}

		public bool Exist(string item)
		{
			return _inventory.ContainsKey(item);
		}

        public int GetStock(string key)
        {
			foreach (var item in _inventory)
			{
				if (key.Equals(item.Key))
				{
					return item.Value;
				}
			}
			return 0;
		}

        public Dictionary<string, int> GetAllStock()
        {
			return _inventory;
        }
    }
}
