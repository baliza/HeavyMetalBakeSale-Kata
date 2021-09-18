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
        public void PurchaseServcie_GetInstance_Test()
        {
            PurchaseService ps = PurchaseService.GetInstance();
            PurchaseService ps2 = PurchaseService.GetInstance();
            Assert.AreEqual(ps, ps2);
        }

        [TestMethod]
        public void PurchaseService_Purchase_Test()
        {
            PurchaseService ps = PurchaseService.GetInstance();
            Assert.AreEqual(2, ps.Purchase(2, 4));
        }
    }
}
