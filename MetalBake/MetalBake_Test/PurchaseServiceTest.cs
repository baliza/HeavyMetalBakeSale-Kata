using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MetalBake.services;

namespace MetalBake_Test
{
    [TestClass]
    public class PurchaseServiceTest
    {
        [TestMethod]
        public void GetInstance_Test()
        {
            PurchaseService sut = PurchaseService.GetInstance();
            PurchaseService sut2 = PurchaseService.GetInstance();
            Assert.AreEqual(sut, sut2);
        }

        [TestMethod]
        public void Purchase_Test()
        {
            PurchaseService sut = PurchaseService.GetInstance();
            Assert.AreEqual(2, sut.Purchase(2, 4));
        }

        [TestMethod]
        public void OrderPrice_Test()
        {
            PurchaseService sut = PurchaseService.GetInstance();
            decimal total = sut.OrderPrice("B,C,W");
            Assert.AreEqual(3.50m, total);
        }
    }
}