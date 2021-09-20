using MetalBakeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MetalBake.Test.Framework
{
    [TestClass]
    public class InventoryTest
    {
        [TestMethod]
        public void Test_Inventory_Created()
        {
            Inventory inventory = new Inventory();
            List<Item> itemList = new List<Item>();
            itemList.Add(new Item('C', "Cake", 10));
            itemList.Add(new Item('W', "Water", 7));
            itemList.Add(new Item('B', "Brownie", 21));
            itemList.Add(new Item('M', "Muffin", 2));
            for (int i = 0; i < itemList.Count; i++)
            {
                Assert.AreEqual(itemList[i].ToString().Trim(), inventory.ItemList[i].ToString().Trim());
            }
        }
    }
}