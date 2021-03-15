using System;

namespace BRQ.CreditTest.ConsoleApp.ViewModel
{
    public class TradeInfoViewModel
    {
        public double Value { get; set; }
        public string ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public bool IsPoliticallyExposed { get; set; }
    }
}
