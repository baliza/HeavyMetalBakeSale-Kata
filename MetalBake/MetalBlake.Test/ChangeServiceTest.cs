using MetalBake.Models;
using MetalBake.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBlake.Test
{
    [TestClass]
    public class ChangeServiceTest
    {
        [TestMethod]
        public void Test_ChangeService_IsUnique()
        {
            ChangeService service1 = ChangeService.GetInstance();
            ChangeService service2 = ChangeService.GetInstance();
            Assert.AreEqual(service1, service2);
        }

        [TestMethod]
        public void Test_Get_Change()
        {
            List<Item> PurchaseItems = new List<Item>();
            Order order = new Order(PurchaseItems);
            order.TotalPrice = 2;

            ChangeService service1 = ChangeService.GetInstance();
            Assert.AreEqual(2, service1.GetChange(order, 4));
        }        
        
        [TestMethod]
        public void Test_Get_Change_With_Insuficient_Money()
        {
            List<Item> PurchaseItems = new List<Item>();
            Order order = new Order(PurchaseItems);
            order.TotalPrice = 2;

            ChangeService service1 = ChangeService.GetInstance();
            Assert.ThrowsException<Exception>(() => { service1.GetChange(order, 1); });
        }
    }
}
