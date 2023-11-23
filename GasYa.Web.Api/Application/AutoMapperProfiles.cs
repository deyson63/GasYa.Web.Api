using AutoMapper;
using GasYa.Web.Api.Application.Dtos;
using GasYa.Web.Api.Domain.Entities;

namespace GasYa.Web.Api.Application;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Client, UserDto>();
        CreateMap<GasStation, GasStationDto>();
        CreateMap<Fuel, FuelDto>();
        CreateMap<Promotion, PromotionDto>();
        CreateMap<Inventory, InventoryDto>();
    }   
}
