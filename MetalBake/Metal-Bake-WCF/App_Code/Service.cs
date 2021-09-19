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
    private Dictionary<string, int> _inventory = new Dictionary<string, int>
        {
            {"B", 40 },
            {"M", 36 },
            {"C", 24 },
            {"W", 30 }
        };
    public bool Exist(string item)
    {
        return item.Equals(_inventory[item]);
    }
    public int GetStock(string key)
    {
        foreach (var item in _inventory)
        {
            if (key.Equals(item.Key))
            {
                return item.Value;
            }
        }
        return 0;
    }
    public bool CheckStock(string item, int amount)
    {
        return _inventory[item] > amount;
    }
    public void ReduceStock(string item, int amount)
    {
        _inventory[item] -= amount;
    }
}
