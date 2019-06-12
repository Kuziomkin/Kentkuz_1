using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kentkuz_1.Modals;

namespace Kentkuz_1.Collections
{
    public delegate void Message(Trade trade);
    public class TradesCollection
    {
        public event Message TradeAdded;
        private List<Trade> trades;
        public TradesCollection()
        {
            trades = new List<Trade>();
        }
        public void Add(Trade trade)
        {
            trades.Add(trade);
            TradeAdded(trade);
        }
    }
}
