using MetalBandBakery.InventoryWCF.Repositories;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public int CheckStock(string itemId)
	{
		IInventoryRepository svc = new InventoryRepository();
		var item = svc.GetItem(itemId);
		if (item == null)
			return 0;
		return item.Quantity;
	}

	public bool ReduceStock(string itemId)
	{
		IInventoryRepository svc = new InventoryRepository();
		var item = svc.GetItem(itemId);
		if (item == null)
			return false;
		if (item.Quantity <= 0)
			return false;
		item.Quantity--;
		svc.Save(item);
		return true;
	}
}