using System;
using System.Collections.Generic;

namespace BRQ.CreditTest.ConsoleApp.ViewModel
{
    public class TradeViewModel
    {
        public DateTime ReferenceDate { get; set; }
        public int NumberOfTrades { get; set; }
        public List<TradeInfoViewModel> Trades { get; set; }
    }
}
