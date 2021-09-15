using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class InventoryService : IInventoryService
    {
        public Inventory MetalBakeInventory;

        public InventoryService(Inventory inventory)
        {
            MetalBakeInventory = inventory;
            Console.WriteLine("---"+MetalBakeInventory);
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
            foreach (var item in MetalBakeInventory.ItemList)
            {
                if (item.Code == code)
                {
                    return item;
                }
            }
            return null;
        }

       
        public override string ToString()
        {
            return MetalBakeInventory.ToString();
        }

        public void DelItem(Item item)
        {
            foreach(var copyItem in MetalBakeInventory.ItemList)
            {
                if(copyItem.Code == item.Code)
                {
                    copyItem.Amount--;
                }
            }
        }
    }
}
