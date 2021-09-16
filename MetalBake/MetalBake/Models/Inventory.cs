using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetalBake.Models
{
    public class Inventory : IInventory
    {
        public List<Item> ItemList;

        public Inventory()
        {
            List<Item> itemList = new List<Item>();
            itemList.Add(new Item('C', "Cake", 10));
            itemList.Add(new Item('W', "Water", 7));
            itemList.Add(new Item('B', "Brownie", 21));
            itemList.Add(new Item('M', "Muffin", 2));
            ItemList = itemList;
        }

        public bool isOnStock(Item item)
        {
            return item.Amount > 0;
        }
        public double calculateAmountPrice(double[] priceList, int[] amountList)
        {
            double totalPrice = 0;
            for (int i = 0; i < priceList.Length; i++)
            {
                totalPrice += priceList[i] * amountList[i];
            }

            return totalPrice;
        }
        public Item checkItemByChar(char code)
        {
            foreach (var item in ItemList)
            {
                if (item.Code == code)
                {
                    return item;
                }
            }
            return null;
        }
        public void DelItem(Item item)
        {
            foreach (var copyItem in ItemList)
            {
                if (copyItem.Code == item.Code)
                {
                    copyItem.Amount--;
                }
            }
        }
        public override string ToString()
        {
            string first = string.Join("\n", ItemList.Select(e => e.ToString()).ToArray());
            return first;
        }
    }
}
