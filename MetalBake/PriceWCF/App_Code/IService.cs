using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

	[OperationContract]
	decimal CalculateOrderPrice(Dictionary<string, int> orderList);
	[OperationContract]
	decimal GetPrice(string key);
	[OperationContract]
	List<ItemPrice> GetAllPrices();
	[OperationContract]
	decimal SetPrice(ItemPrice item);
	[OperationContract]
	void TxtListPrice();
}

