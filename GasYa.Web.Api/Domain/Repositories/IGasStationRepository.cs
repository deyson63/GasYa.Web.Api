using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Repositories;

public interface IGasStationRepository
{
    Task<GasStationAggregate> GetByIdAsync(int id);
}