using MetalBandBakery.InventoryWCF.Repositories;
using System.Collections.Generic;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    private IInventoryRepository _svc;

    public Service()
    {
        _svc = new InventoryRepository();
    }

    public bool SetStock(string itemId, int quantity)
    {
        var item = _svc.GetItem(itemId);
        if (item == null)
            return false;
        item.Quantity = quantity;
        _svc.Save(item);
        return true;
    }

    public int CheckStock(string itemId)
    {
        var item = _svc.GetItem(itemId);
        if (item == null)
            return 0;
        return item.Quantity;
    }

    public List<Item> GetAllStock()
    {
        return _svc.GetAllItems();
    }

    public bool ReduceStock(string itemId)
    {
        var item = _svc.GetItem(itemId);
        if (item == null)
            return false;
        if (item.Quantity <= 0)
            return false;
        item.Quantity--;
        _svc.Save(item);
        return true;
    }
}