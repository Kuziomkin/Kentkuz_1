using Kentkuz_1.Modals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Kentkuz_1.Collections;


namespace Kentkuz_tests.Collections
{
    [TestClass]
    public class TradeCollectionsTests
    {        
        private List<Trade> trades;
        [TestInitialize]
        public void Setup()
        {
            trades = new List<Trade>();
        }        
        [TestMethod]
        public void Trade_Add_Collections_Method_Test()
        {
            Trade trade = new Trade(DateTime.Now, 25.05, 5);
            trades.Add(trade);
            Assert.AreEqual(1, trades.Count);
        }
        [TestMethod]
        public void Trade_Delete_Collection_Method_Test()
        {
            Trade trade = new Trade(DateTime.Now, 25.05, 5);
            trades.Remove(trade);
            Assert.AreEqual(0, trades.Count);
        }
        [TestMethod]
        public void Trade_Find_Collection_Method_Test()
        {
            Trade first = new Trade(DateTime.Now, 25.05, 5);
            trades.Add(first);
            Trade second = new Trade(DateTime.Now, 25.05, 5);
            trades.Add(second);
            Assert.AreEqual(2, trades.Count);
            Assert.IsTrue(trades.Contains(second));
        }
        [TestMethod] 
        public void Trades_Clear_Method_Test()
        {            
            Add_Trades_Collection_Method_Test(15);
        }
        public void Add_Trades_Collection_Method_Test(int count)
        {            
            for (int i=0; i<count; i++)
            {
                Trade trade = new Trade(new DateTime(2014, 5, i+1), i, i);
                trades.Add(trade);
            }            
            
        }
        [TestMethod]
        public void Find_Trade_ByPrice_Method_Test()
        {
            Add_Trades_Collection_Method_Test(10);
            Trade trade = trades.SingleOrDefault(t => t.Price == 5);
            Assert.IsNotNull(trade);
            Assert.AreEqual(5, trade.Price);
        }
        [TestMethod]
        public void Find_Trades_Method_Test()
        {
            DateTime date = new DateTime(2014, 5, 1);
            Add_Trades_Collection_Method_Test(20);
            IEnumerable<Trade> tradeSet = trades.Where(t => t.Date > date);
            Assert.IsNotNull(tradeSet);
            Assert.AreEqual(19, tradeSet.Count());
            foreach (Trade item in tradeSet)
            {
                Assert.IsTrue(item.Date > date);
            }
        }
        [TestMethod]
        public void Get_Last_Trade_Method_Test()
        {
            Add_Trades_Collection_Method_Test(20);
            Trade last = trades.Last();
            Assert.AreEqual(20, last.Date.Day);
        }
        private string lastTradeSymbol;
        private TradesCollection tradesCollection;
        private void UpdateLastTradeSymbol(Trade trade)
        {
            lastTradeSymbol = trade.Symbol;
        }
        [TestMethod]       
        public void Notify_Add_Trade_Method_Test()
        {
            tradesCollection = new TradesCollection();
            tradesCollection.TradeAdded += UpdateLastTradeSymbol;
            Trade trade = new Trade("SRT-021231", "RTS-6.19", new DateTime(2019,01,5), 125000, 5);
            tradesCollection.Add(trade);
            Assert.AreEqual(trade.Symbol, lastTradeSymbol);
        }
    }
}

