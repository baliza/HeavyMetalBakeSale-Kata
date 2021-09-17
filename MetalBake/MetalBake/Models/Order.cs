using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetalBake.Models
{
    public class Order
    {
        private readonly List<Item> _buyItemsList;
        public decimal TotalPrice { get; set; }

        public Order()
        {
            _buyItemsList = new List<Item>();
        }

        public void AddItem(Item item, decimal price)
        {
            _buyItemsList.Add(item);
            TotalPrice += price;
        }

        public string CreateOrderSummary()
        {
            List<string> listNames = GetItemsListNames();
            List<Tuple<string, int>> cuantityItems = GetCuantityOfEachItem(listNames);
            return GetSummary(cuantityItems);
        }

        private List<string> GetItemsListNames()
        {
            List<string> listNames = new List<string>();
            foreach (var item in _buyItemsList)
            {
                listNames.Add(item.GetName());
            }
            return listNames;
        }

        private List<Tuple<string, int>> GetCuantityOfEachItem(List<string> listNames)
        {
            var query = from name in listNames group name by name into newGroup select newGroup;
            List<Tuple<string, int>> cuantityItems = new List<Tuple<string, int>>();
            foreach (var item in query)
            {
                cuantityItems.Add(new Tuple<string, int>(item.Key, item.Count()));
            }
            return cuantityItems;
        }

        private string GetSummary(List<Tuple<string, int>> cuantityItems)
        {
            string summary = "";
            foreach (var item in cuantityItems)
            {
                summary += $"{item.Item2}{item.Item1}, ";
            }
            return $"Thank you for purchasing: { summary}";
        }
    }
}