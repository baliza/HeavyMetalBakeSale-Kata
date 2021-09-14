using MetalBake.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBlake.Test
{
    [TestClass]
    public class PriceTest
    {
        PriceService service = new PriceService();
        [TestMethod]
        public void Test_Get_Item_Price()
        {
            Assert.AreEqual(1, service.GetItemPrice('M'));
        } 
              
        [TestMethod]
        public void Test_Get_NonExistingItem_Price()
        {
            Assert.ThrowsException<KeyNotFoundException>(() => service.GetItemPrice('H'));
        }

    }
}
