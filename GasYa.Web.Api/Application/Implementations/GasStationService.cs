using GasYa.Web.Api.Application.Contracts;
using GasYa.Web.Api.Application.Dtos;
using GasYa.Web.Api.Application.Queries;

namespace GasYa.Web.Api.Application.Implementations;

public class GasStationService : IGasStationService
{
    public async Task<List<GasStationDto>> GasStationAsync(GetGasStationsQuery query)
    {
        return new List<GasStationDto>
        {
            new GasStationDto { Id = 1, Name = "Estación 1" },
            new GasStationDto { Id = 2, Name = "Estación 2" }
        };
    }
}
