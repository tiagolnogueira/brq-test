using BRQ.CreditTest.Domain.Entities;
using BRQ.CreditTest.Domain.Enums;
using System;
using System.Threading.Tasks;

namespace BRQ.CreditTest.Domain.Interfaces
{
    public interface ITradeService
    {
        Category GetRisk(Trade trade, DateTime referenceDate);
    }
}
