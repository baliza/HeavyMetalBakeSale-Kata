using MetalBake.Interfaces;
using MetalBake.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    public bool Exist(string item)
    {
        IInventoryRepository svc = new InventoryRepository();
        return svc.Exist(item);
        //return !item.Equals(_inventory[item]);  // ****!!
    }
    public int GetStock(string key)
    {
        IInventoryRepository svc = new InventoryRepository();
        return svc.GetStock(key);
        //foreach (var item in _inventory)
        //{
        //    if (key.Equals(item.Key))
        //    {
        //        return item.Value;
        //    }
        //}
        //return 0;
    }
    public bool CheckStock(string id, int amount)
    {
        IInventoryRepository svc = new InventoryRepository();
        return svc.CheckStock(id, amount);
        //return _inventory[id] > amount;
    }
    public bool ReduceStock(string id, int amount)
    {
        if (id == null)
            return false;
        if (amount <= 0)
            return false;
        IInventoryRepository svc = new InventoryRepository();
        svc.ReduceStock(id, amount);
        return true;
    }
    public bool IncreaseStock(string id, int amount)
    {
        if (id == null)
            return false;
        if (amount <= 0)
            return false;
        IInventoryRepository svc = new InventoryRepository();
        svc.IncreaseStock(id, amount);
        return true;
    }
}
