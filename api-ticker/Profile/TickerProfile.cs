using AutoMapper;
using ticker_api.Data.Dto;
using ticker_api.Models;

namespace TickerApi.Profiles;

public class TickerProfile : Profile
{
    public TickerProfile()
    {
        CreateMap<CreateTickerDto, TickerModel>();
        CreateMap<TickerModel, ReadTickerDto>();
    }
}