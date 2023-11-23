using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Services;

public interface IGasStationManagementService
{
    Task<GasStationAggregate> GetGasStationByIdAsync (int id);
    Task<IEnumerable<GasStationAggregate>> GetGasStationsByNameAsync(string name);
    
    Task<GasStationAggregate> AddGasStationAsync (string name);
    Task UpdateAsync(GasStationAggregate gasStation);
    Task DeleteAsync(int id);
}