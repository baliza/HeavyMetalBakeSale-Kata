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
	void ReduceStock(string item, int amount);
}

