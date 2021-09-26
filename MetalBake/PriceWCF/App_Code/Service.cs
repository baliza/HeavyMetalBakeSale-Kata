using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService
{
	IPriceRepository _priceRepository = new PriceRepository();
	public Service()
	{
		_priceRepository = new PriceRepository();
	}
	public decimal CalculateOrderPrice(Dictionary<string, int> orderList)
	{
		return 0; //_priceRepository.CalculateOrderPrice();
	}

	public List<ItemPrice> GetAllPrices()
	{
		return _priceRepository.GetAllPrices();
	}

    public decimal GetPrice(string key)
    {
		return _priceRepository.GetPrice(key);
    }

    public decimal SetPrice(ItemPrice item)
    {
		_priceRepository.SetPrice(item);
		return _priceRepository.GetPrice(item.ItemId);
    }
	public void TxtListPrice()
    {
		_priceRepository.TxtListPrice();
    }

}
