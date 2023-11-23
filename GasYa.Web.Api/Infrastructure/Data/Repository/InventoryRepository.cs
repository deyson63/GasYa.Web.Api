using GasYa.Web.Api.Domain.Aggregates;
using GasYa.Web.Api.Domain.Repositories;
using GasYa.Web.Api.Infrastructure.Data.Context;

namespace GasYa.Web.Api.Infrastructure.Data.Repository;

public class InventoryRepository : IInventoryRepository
{
    private readonly GasYaDbContext _dbContext;
    
    public InventoryRepository(GasYaDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<InventoryAggregate> GetByGasStationAndFuelAsync(int gasStationId, int fuelId)
    {
        return await _dbContext.Inventories.FindAsync(gasStationId, fuelId);
    }
}