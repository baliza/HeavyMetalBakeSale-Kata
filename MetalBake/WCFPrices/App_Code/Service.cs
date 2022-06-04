using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService
{
    private IPriceRepository _priceRepository;

    public Service()
    {
        _priceRepository = new PriceRepository();
    }

    public List<ItemPrice> GetAllPrices()
    {
        return _priceRepository.GetAllPrices();
    }

    public ItemPrice GetItemPrice(string itemId)
    {
        return _priceRepository.GetItemPrice(itemId);
    }

    public bool UpdateItemPrice(ItemPrice item)
    {
        return _priceRepository.UpdateItemPrice(item.ItemId, item.Price);
    }
}