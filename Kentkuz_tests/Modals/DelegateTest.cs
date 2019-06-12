using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kentkuz_tests.Modals
{
    [TestClass]
    public class DelegateTest
    {
        int count;
        public delegate void Change(int number);
        public void UpgradeCount(Change Method, int number)
        {
            Method(number);        
        }
        public void Add(int number)
        {
            count=count+number;
        }
           
        [TestMethod]
        public void Change_Method_Delegate_Test()
        {
            UpgradeCount(Add, 10);
            Assert.AreEqual(10, count);
        }
    }
}
