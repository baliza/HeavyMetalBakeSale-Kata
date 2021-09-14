using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetalBake.services;

namespace MetalBake_Test
{
    [TestClass]
    public class InventoryManagerTest
    {
        [TestMethod]
        public void PriceCount_B_C_W_Test()
        {
            InventoryManagerService ims = new InventoryManagerService();
            Assert.AreEqual(3.50m, ims.PriceCount("B,C,W"));
        }

        [TestMethod]
        public void PriceCount_Non_Registered_Product_Test()
        {
            InventoryManagerService ims = new InventoryManagerService();
            Assert.AreEqual(0, ims.PriceCount("A"));
        }


    }
}

