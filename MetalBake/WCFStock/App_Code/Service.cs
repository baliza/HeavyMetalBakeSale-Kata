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
    private IStockRepository _stockRepository;

    public Service()
    {
        _stockRepository = new StockRepository();
    }

    public List<ItemStock> GetAllStock()
    {
        return _stockRepository.GetAllStock();
    }

    public int GetItemStock(string itemId)
    {
        var stock = _stockRepository.GetItemStock(itemId);
        return stock <= 0 ? -1 : stock;
    }

    public bool ReduceItemStock(string itemId)
    {
        var stock = _stockRepository.GetItemStock(itemId);
        if (stock > 0)
        {
            stock--;
            _stockRepository.SetItemStock(itemId, stock);
            return true;
        }
        return false;
    }

    public string SetItemStock(string itemId, int cuantity)
    {
        return (_stockRepository.SetItemStock(itemId, cuantity)) ? "stock added successfully" : "Cannot add stock to an item that does not exist";
    }
}