using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kentkuz_1.Modals;

namespace Kentkuz_tests.Modals
{
    [TestClass]
    public class TradeTests
    {
        [TestMethod]
        public void TradeConstructor_Test()
        {
            DateTime dateTime = DateTime.Now;
            double price = 125.000;
            double amount = 5;
            string portfolio = "STR123-FR-05";
            string symbol = "RTS-6.19";

            Trade trade = new Trade(portfolio, symbol, dateTime, price, amount);
            Assert.AreEqual(dateTime, trade.Date);
            Assert.AreEqual(price, trade.Price);
            Assert.AreEqual(amount, trade.Amount);
            Assert.AreEqual(portfolio, trade.Portfolio);
            Assert.AreEqual(symbol, trade.Symbol);
        }
        [TestMethod]
        public void Sum_Trade_Method_Test()
        {
            DateTime dateTime = DateTime.Now;
            double price = 125000;
            double amount = 5;
            string portfolio = "STR123-FR-05";
            string symbol = "RTS-6.19";

            Trade trade = new Trade(portfolio, symbol, dateTime, price, amount);
            Assert.AreEqual(price * amount, trade.Sum);
            Assert.IsTrue(trade.Sum > 0);
        }

    }
}
