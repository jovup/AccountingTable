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
                .ForMember( dest => dest.Type, option => option.MapFrom( source => ( CategoryEnum )source.Categoryyy ) )
                .ForMember( dest => dest.Date, option => option.MapFrom( source => source.Dateee ) )
                .ForMember( dest => dest.Amount, option => option.MapFrom( source => ( decimal )source.Amounttt ) );

            CreateMap<AccountingInputViewModel, AccountBook>( )
                .ForMember( dest => dest.Id, option => option.MapFrom( source => source.Id ) )
                .ForMember( dest => dest.Categoryyy, option => option.MapFrom( source => ( int )source.Category ) )
                .ForMember( dest => dest.Amounttt, option => option.MapFrom( source => source.Amount ) )
                .ForMember( dest => dest.Dateee, option => option.MapFrom( source => source.Date ) )
                .ForMember( dest => dest.Remarkkk, option => option.MapFrom( source => source.Remark ) );
        }
    }
}