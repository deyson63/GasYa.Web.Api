using GasYa.Web.Api.Domain.Aggregates;
using GasYa.Web.Api.Domain.Repositories;
using GasYa.Web.Api.Infrastructure.Data.Context;

namespace GasYa.Web.Api.Infrastructure.Data.Repository;

public class GasStationRepository : IGasStationRepository
{
    private readonly GasYaDbContext _dbContext;
    
    public GasStationRepository(GasYaDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<GasStationAggregate> GetByIdAsync(int id)
    {
        return await _dbContext.GasStations.FindAsync(id);
    }
}