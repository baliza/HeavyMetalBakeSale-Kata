using MetalBandBakery.Core.Services;

namespace MetalBandBakey.Infra.Repository
{
	public class SoapStockService : IStockService
	{
		public bool CheckStock(string itemId)
		{
			WCFStockService.IService svc = new WCFStockService.ServiceClient();
			return svc.CheckStock(itemId) > 0;
		}

		public void ReduceStock(string itemId)
		{
			WCFStockService.IService svc = new WCFStockService.ServiceClient();
			svc.ReduceStock(itemId);
		}
	}
}