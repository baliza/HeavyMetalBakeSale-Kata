using MetalBakeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MetalBake.Test.Framework
{
    [TestClass]
    public class ItemsTest
    {
        public Inventory inventory;

        [TestInitialize]
        public void Setup()
        {
            inventory = new Inventory();
        }

        [TestMethod]
        public void Test_Item_With_Correct_Price()
        {
            Item item = new Item('1', "2", 1);

            foreach (var copyItem in inventory.ItemList)
            {
                if (copyItem.Code == 'M')
                {
                    item = copyItem;
                }
            }
            Assert.AreEqual(1.20, PieMarketService.GetPrice(item));
        }

        [TestMethod]
        public void Test_Item_Correct_ToString()
        {
            Item expectedItem = new Item('M', "Muffin", 2);
            var actual = from n in inventory.ItemList where n.Code.Equals('M') select n;
            Item item = new Item('1', "2", 1);
            foreach (var item2 in actual)
            {
                item = item2;
            }
            Assert.AreEqual(expectedItem.ToString(), item.ToString());
        }
    }
}