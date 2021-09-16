using MetalBake.Interfaces;
using MetalBake.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBlake.Test
{
    [TestClass]
    public class PriceServiceTest
    {
        public IPriceService GetSut()
        {
            return new PriceService();
        }

        [TestMethod]
        public void Test_Get_Item_Price()
        {
            Assert.AreEqual(1, GetSut().GetItemPrice('M'));
        }

        [TestMethod]
        public void Test_Get_NonExistingItem_Price()
        {
            Assert.ThrowsException<KeyNotFoundException>(() => GetSut().GetItemPrice('H'));
        }
    }
}