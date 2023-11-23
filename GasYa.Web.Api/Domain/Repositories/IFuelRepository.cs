using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Repositories;

public interface IFuelRepository
{
    Task<FuelAggregate> GetByIdAsync(int id);
}