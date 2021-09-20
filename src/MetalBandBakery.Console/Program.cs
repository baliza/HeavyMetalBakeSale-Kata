namespace MetalBandBakery
{
	internal class Program
	{
		private static IStockService _stockService = new StockService();
		private static IPriceService _priceService = new PriceService();

		private static void Main(string[] args)
		{
			var application = new Application(_stockService, _priceService);
			application.Run();
		}
	}
}