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

    public decimal GetItemPrice(string itemId)
    {
        return _priceRepository.GetItemPrice(itemId);
    }
}