using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{
    [OperationContract]
    List<ItemPrice> GetAllPrices();

    [OperationContract]
    ItemPrice GetItemPrice(string itemId);

    [OperationContract]
    bool UpdateItemPrice(ItemPrice item);
}