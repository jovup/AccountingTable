using AccountingTable.Models;
using AccountingTable.Models.ViewModels;
using AutoMapper;

namespace AccountingTable.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile( )
        {
            CreateMap<AccountBook, AccountingViewModel>( )
                .ForMember( dest => dest.Type, option => option.MapFrom( source => source.Categoryyy == 0 ? "支出" : "收入" ) )
                .ForMember( dest => dest.Date, option => option.MapFrom( source => source.Dateee ) )
                .ForMember( dest => dest.Amount, option => option.MapFrom( source => ( decimal )source.Amounttt ) );
        }
    }
}