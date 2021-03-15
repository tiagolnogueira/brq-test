using AutoMapper;
using BRQ.CreditTest.ConsoleApp.ViewModel;
using BRQ.CreditTest.Domain.Entities;

namespace BRQ.CreditTest.ConsoleApp.Config
{
    public class AutoMapperConfig : Profile 
    {
        public AutoMapperConfig()
        {
            CreateMap<Trade, TradeViewModel>().ReverseMap();
        }
    }
}
