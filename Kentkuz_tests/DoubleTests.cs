using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kentkuz_tests
{
    [TestClass]
    public class DoubleTests
    {
        public double price;
        public double amount;
        [TestInitialize]
        public void Method_Test1()
        {
            amount = 10;
        }
        [TestMethod]
        public void Default_Price_Method_Test()
        {
            Assert.AreEqual(0, price);
        }
        [TestMethod]
        public void Change_Price_Method_Test()      
        {
            price = 55.01;
            Assert.AreEqual(55.01, price);
        }
        [TestMethod]
        public void Double_Multiplicat_Method_Test()
        {
            price = 2.5;
            double sum = price * amount;
            Assert.AreEqual(25, sum);
        }
      
    }
}
