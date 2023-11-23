using GasYa.Web.Api.Domain.Aggregates;
using GasYa.Web.Api.Domain.Repositories;
using GasYa.Web.Api.Infrastructure.Data.Context;

namespace GasYa.Web.Api.Infrastructure.Data.Repository;

public class FuelRepository : IFuelRepository
{
    private readonly GasYaDbContext _dbContext;

    public FuelRepository(GasYaDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<FuelAggregate> GetByIdAsync(int id)
    {
        return await _dbContext.Fuels.FindAsync(id);
    }
}