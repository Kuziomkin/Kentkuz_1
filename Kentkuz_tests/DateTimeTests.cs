using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kentkuz_tests
{
    [TestClass]
    public class DateTimeTests
    {
        public DateTime dateTime;
        [TestMethod]
        public void Default_DateTime_Method_Tets()
        {
            Assert.AreEqual(1, dateTime.Year);
            Assert.AreEqual(1, dateTime.Month);
            Assert.AreEqual(1, dateTime.Day);
            Assert.AreEqual(0, dateTime.Hour);
            Assert.AreEqual(0, dateTime.Minute);
            Assert.AreEqual(0, dateTime.Second);
        }
        [TestMethod]
        public void Initiliazion_DateTime_Method_Test()
        {
            dateTime = DateTime.Now;
            Assert.AreNotEqual(DateTime.MinValue, dateTime);
        }
        [TestMethod]
        public void Construction_DateTime_Method_Tests()
        {
            dateTime = new DateTime(1989,1,1,10,22,3);
            Assert.AreEqual(1989, dateTime.Year);
            Assert.AreEqual(1, dateTime.Month);
            Assert.AreEqual(1, dateTime.Day);
            Assert.AreEqual(10, dateTime.Hour);
            Assert.AreEqual(22, dateTime.Minute);
            Assert.AreEqual(3, dateTime.Second);
        }
        [TestMethod]
        public void Substraction_DateTime_Method_Test()
        {
            DateTime firstTime = new DateTime(1989, 1, 1, 10, 22, 3);
            DateTime lastTime = new DateTime(1989, 1, 1, 10, 22, 12);
            TimeSpan result = lastTime - firstTime;
            Assert.AreEqual(9, result.Seconds);
        }

    }
}
