using AutoMapper;
using BRQ.CreditTest.ConsoleApp.ViewModel;
using BRQ.CreditTest.Domain.Entities;
using BRQ.CreditTest.Domain.Enums;
using BRQ.CreditTest.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BRQ.CreditTest.ConsoleApp
{
    public class MyApplication
    {
        private readonly IMapper _mapper;
        private readonly ITradeService _tradeService;
        public MyApplication(IMapper mapper, ITradeService tradeService)
        {
            _mapper = mapper;
            _tradeService = tradeService;
        }

        public List<Category> Run()
        {
            string[] lines = File.ReadAllLines(@".\Exemplo\exemplo.txt");
            var trade = new TradeViewModel();
            trade.ReferenceDate = DateTime.Parse(lines[0]);
            trade.NumberOfTrades = int.Parse(lines[1]);
            trade.Trades = new List<TradeInfoViewModel>();
            var lstCategories = new List<Category>();
            for (int i = 2; i < lines.Length; i++)
            {
                var tradeInfo = lines[i].Split(" ");
                var tradeGet = new TradeInfoViewModel()
                {
                    Value = double.Parse(tradeInfo[0]),
                    ClientSector = tradeInfo[1],
                    NextPaymentDate = DateTime.Parse(tradeInfo[2])
                };
                var category = _tradeService.GetRisk(_mapper.Map<Trade>(tradeGet), trade.ReferenceDate);
                lstCategories.Add(category);
            }
            return lstCategories;
        }
    }
}
