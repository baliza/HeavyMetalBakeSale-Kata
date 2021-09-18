using MetalBake.interfaces;
using MetalBake.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.services
{
    public class InventoryManagerService
    {
        private Dictionary<Type, int> stockList = SetItemStock();
        private Brownie _brownie = new Brownie();
        private CakePop _cakePop = new CakePop();
        private Muffin _muffin = new Muffin();
        private Water _water = new Water();

        private static Dictionary<Type, int> SetItemStock()
        {
            Dictionary<Type, int> list = new Dictionary<Type, int>();
            list.Add(typeof(CakePop), 24);
            list.Add(typeof(Brownie), 40);
            list.Add(typeof(Water), 30);
            list.Add(typeof(Muffin), 36);
            return list;
        }

        public string InventoryFilter(string selectedItems)
        {
            char[] totalItems = selectedItems.Replace(",", string.Empty).ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in totalItems)
            {
                if (item.Equals(_cakePop.ShortName))
                {
                    stringBuilder.Append(CheckStock(_cakePop));
                }
                else if (item.Equals(_water.ShortName))
                {
                    stringBuilder.Append(CheckStock(_water));
                }
                else if (item.Equals(_muffin.ShortName))
                {
                    stringBuilder.Append(CheckStock(_muffin));
                }
                else if (item.Equals(_brownie.ShortName))
                {
                    stringBuilder.Append(CheckStock(_brownie));
                }
                else
                {
                    Console.WriteLine($"El item {item} no existe");
                }
            }
            string availableItems = stringBuilder.ToString();
            availableItems = availableItems.Remove(availableItems.Length - 1);
            return availableItems;
        }

        private string CheckStock(IProduct product)
        {
            if (stockList[product.GetType()] > 0)
            {
                stockList[product.GetType()]--;
                return $"{product.ShortName},";
            }
            else
            {
                Console.WriteLine("No hay suficiente stock");
                return string.Empty;
            }
        }
    }
}