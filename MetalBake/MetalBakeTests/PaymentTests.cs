using MetalBake.Models;
using MetalBake.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MetalBakeTests
{
    [TestClass]
    public class PaymentTests
    {
        [TestMethod]
        public void NeedMoneyBack_False()
        {
            PaymentService paymentService = new PaymentService();
            bool expected = false;
            bool actual = paymentService.NeedMoneyBack(10, 10);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NeedMoneyBack_true()
        {
            PaymentService paymentService = new PaymentService();
            bool expected = true;
            bool actual = paymentService.NeedMoneyBack(10, 15);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CoinsAreEnough_False()
        {
            PaymentService paymentService = new PaymentService();
            bool expected = false;
            bool actual = paymentService.CoinsAreEnough(15, 10);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CoinsAreEnough_True()
        {
            PaymentService paymentService = new PaymentService();
            bool expected = true;
            bool actual = paymentService.CoinsAreEnough(10, 15);
            Assert.AreEqual(expected, actual);
        }
    }
}
