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
    List<ItemStock> GetAllStock();

    [OperationContract]
    int GetItemStock(string itemId);

    [OperationContract]
    bool ReduceItemStock(string itemId);

    [OperationContract]
    string SetItemStock(string itemId, int cuantity);
}