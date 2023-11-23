using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Repositories;

public interface IInventoryRepository
{
    Task<InventoryAggregate> GetByGasStationAndFuelAsync(int gasStationId, int fuelId);
}