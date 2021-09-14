using MetalBake.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.services
{
    public class InventoryManagerService
    {
        private Dictionary<Type, decimal> priceList = SetItemValue();
        private Dictionary<Type, int> stockList = SetItemStock();
        private Brownie _brownie = new Brownie();
        private CakePop _cakePop = new CakePop();
        private Muffin _muffin = new Muffin();
        private Water _water = new Water();
        private static Dictionary<Type, decimal> SetItemValue ()
        {
            Dictionary<Type, decimal> list = new Dictionary<Type, decimal>();
            list.Add(typeof(CakePop), 1.35m);
            list.Add(typeof(Brownie), 0.65m);
            list.Add(typeof(Water), 1.50m);
            list.Add(typeof(Muffin), 1);
            return list;
        }
        private static Dictionary<Type, int> SetItemStock()
        {
            Dictionary<Type, int> list = new Dictionary<Type, int>();
            list.Add(typeof(CakePop), 24);
            list.Add(typeof(Brownie), 40);
            list.Add(typeof(Water), 30);
            list.Add(typeof(Muffin), 36);
            return list;

        }

        public decimal PriceCount(string selectedItems)
        {
            decimal total = 0;
            char[] totalItems = selectedItems.Replace(",", string.Empty).ToCharArray();
            foreach(var item in totalItems)
            {
                if (item.Equals(_cakePop.shortName))
                {
                    if (stockList[typeof(CakePop)] > 0)
                    {
                        stockList[typeof(CakePop)]--;
                        total += priceList[typeof(CakePop)];
                    }
                    else
                    {
                        Console.WriteLine("No hay suficiente stock");
                    }
                }
                else if (item.Equals(_water.shortName))
                {
                    if (stockList[typeof(Water)] > 0)
                    {
                        stockList[typeof(Water)]--;
                        total += priceList[typeof(Water)];
                    }
                    else
                    {
                        Console.WriteLine("No hay suficiente stock");
                    }
                }
                else if (item.Equals(_muffin.shortName))
                {
                    if (stockList[typeof(Muffin)] > 0)
                    {
                        stockList[typeof(Muffin)]--;
                        total += priceList[typeof(Muffin)];
                    }
                    else
                    {
                        Console.WriteLine("No hay suficiente stock");
                    }
                }
                else if (item.Equals(_brownie.shortName))
                {
                    if (stockList[typeof(Brownie)] > 0)
                    {
                        stockList[typeof(Brownie)]--;
                        total += priceList[typeof(Brownie)];
                    }
                    else
                    {
                        Console.WriteLine("No hay suficiente stock");
                    }
                }
                else
                {
                    Console.WriteLine($"El item {item} no existe");
                }
            }
            return total;
        }
    }

}
