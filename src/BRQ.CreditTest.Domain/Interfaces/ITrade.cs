using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.CreditTest.Application.Interfaces
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSelector { get; }
        DateTime NextPaymentDate { get; }
        bool IsPoliticallyExposed { get; }
    }
}
