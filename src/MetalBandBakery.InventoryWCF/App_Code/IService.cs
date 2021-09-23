using MetalBandBakery.InventoryWCF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    [WebGet(UriTemplate = "/CheckStock?itemId={itemId}")]
    int CheckStock(string itemId);

    [OperationContract]
    bool ReduceStock(string itemId);

    [OperationContract]
    bool SetStock(string itemId, int quantity);

    [OperationContract]
    List<Item> GetAllStock();
}