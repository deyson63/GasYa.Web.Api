using GasYa.Web.Api.Application.Dtos;
using GasYa.Web.Api.Application.Queries;

namespace GasYa.Web.Api.Application.Contracts;

public interface IGasStationService
{
    Task<List<GasStationDto>> GasStationAsync(GetGasStationsQuery query);
}