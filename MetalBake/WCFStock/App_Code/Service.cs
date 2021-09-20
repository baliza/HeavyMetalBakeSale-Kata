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

    public int GetItemStock(string itemId)
    {
        return _stockRepository.GetItemStock(itemId);
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
}