using BRQ.CreditTest.Domain.Entities;
using BRQ.CreditTest.Domain.Enums;
using BRQ.CreditTest.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace BRQ.CreditTest.Application.Services
{
    public class TradeService : ITradeService
    {
        public Category GetRisk(Trade trade, DateTime referenceDate)
        {
            if (trade.IsPoliticallyExposed)
            {
                return Category.PEP;
            }
            if (trade.Value > 1000000 && trade.ClientSelector.ToUpper().Equals("PRIVATE"))
            {
                return Category.HIGHRISK;
            }
            else if (trade.Value > 1000000 && trade.ClientSelector.ToUpper().Equals("PUBLIC"))
            {
                return Category.MEDIUMRISK;
            }
            else if (referenceDate.Subtract(trade.NextPaymentDate).TotalDays > 30)
            {
                return Category.DEFAULTED;
            }
            return Category.DEFAULTED;
        }
    }
}
