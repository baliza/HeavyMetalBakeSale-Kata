using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetalBake.services;
using MetalBake.models;
using System;

namespace MetalBake_Test
{
    [TestClass]
    public class InventoryManagerTest
    {
        [TestMethod]
        public void InventoryFilter_B_C_W_Item_List_Test()
        {
            InventoryManagerService sut = new InventoryManagerService();
            string itemList = sut.InventoryFilter("B,C,W");
            Assert.AreEqual("B,C,W", itemList);
        }

        [TestMethod]
        public void InventoryFilter_Invalid_Chars_Item_List_Test()
        {
            InventoryManagerService sut = new InventoryManagerService();
            string itemList = sut.InventoryFilter("AAAAAB,M,W,,,XXXX");
            Assert.AreEqual("B,M,W", itemList);
        }
    }
}