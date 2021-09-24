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
    IInventoryRepository _inventoryRepository = new InventoryRepository();
    public Service(IInventoryRepository priceRepository)
    {
        _inventoryRepository = priceRepository;
    }
    public bool Exist(string item)
    {
        return _inventoryRepository.Exist(item);
    }
    public int GetStock(string key)
    {
        return _inventoryRepository.GetStock(key);
    }
    public bool CheckStock(string id, int amount)
    {
        return _inventoryRepository.CheckStock(id, amount);
    }
    public bool ReduceStock(string id, int amount)
    {
        if (id == null)
            return false;
        if (amount <= 0)
            return false;
        _inventoryRepository.ReduceStock(id, amount);
        return true;
    }
    public bool IncreaseStock(string id, int amount)
    {
        if (id == null)
            return false;
        if (amount <= 0)
            return false;
        _inventoryRepository.IncreaseStock(id, amount);
        return true;
    }
    public string SetItemStock(string itemId, int cuantity)
    {
        return (_inventoryRepository.SetItemStock(itemId, cuantity)) ? "Stock Added" : "Item doesn't exist or amount is null";
    }
    public List<ItemStock> GetAllStock()
    {
        return _inventoryRepository.GetAllStock();
    }
}
