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
        public void PurchaseData_B_C_W_Price_Test()
        {
            InventoryManagerService ims = new InventoryManagerService();
            ShoppingCart shoppingCart = ims.PurchaseData("B,C,W");
            Assert.AreEqual(3.50m, shoppingCart.totalPrice);
        }

        [TestMethod]
        public void PurchaseData_Non_Registered_Product_Total_Price_Test()
        {
            InventoryManagerService ims = new InventoryManagerService();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ims.PurchaseData("A"));
        }

        [TestMethod]
        public void PurchaseData_B_C_W_Item_List_Test()
        {
            InventoryManagerService ims = new InventoryManagerService();
            ShoppingCart shoppingCart = ims.PurchaseData("B,C,W");
            Assert.AreEqual("B,C,W", shoppingCart.itemList);
        }

        [TestMethod]
        public void PurchaseData_Invalid_Chars_Item_List_Test()
        {
            InventoryManagerService ims = new InventoryManagerService();
            ShoppingCart shoppingCart = ims.PurchaseData("AAAAAB,M,W,,,XXXX");
            Assert.AreEqual("B,M,W", shoppingCart.itemList);
        }


    }
}

