using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentkuz_1.Modals
{
    public class Trade
    {
        public DateTime Date;
        public double Price;
        public double Amount;
        public string Portfolio;
        public string Symbol;

        public Trade(DateTime date, double price, double amount) :
            this(String.Empty, String.Empty, date, price, amount) { }
        public Trade(string portfolio, string symbol,  DateTime date, double price, double amount)
        {
            this.Date = date;
            this.Price = price;
            this.Amount = amount;
            this.Portfolio = portfolio;
            this.Symbol = symbol;
        }
        public double Sum
        {
            get { return this.Price * this.Amount; }           
        }
    }
}
