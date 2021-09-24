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
	bool Exist(string item);
	[OperationContract]
	int GetStock(string key);
	[OperationContract]
	bool CheckStock(string item, int amount);
    [OperationContract]
    bool ReduceStock(string item, int amount);
	[OperationContract]
	bool IncreaseStock(string item, int amount);
	[OperationContract]
	List<ItemStock> GetAllStock();
}

