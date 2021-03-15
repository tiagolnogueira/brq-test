using BRQ.CreditTest.Application.Interfaces;
using System;

namespace BRQ.CreditTest.Domain.Entities
{
    public class Trade : ITrade
    {
        public double Value { get; set; }
        public string ClientSelector { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public bool IsPoliticallyExposed { get; set; }
    }
}
