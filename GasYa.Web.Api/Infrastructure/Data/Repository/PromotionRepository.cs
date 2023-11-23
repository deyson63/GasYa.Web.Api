using GasYa.Web.Api.Domain.Aggregates;
using GasYa.Web.Api.Domain.Repositories;
using GasYa.Web.Api.Infrastructure.Data.Context;

namespace GasYa.Web.Api.Infrastructure.Data.Repository;

public class PromotionRepository : IPromotionRepository
{
    private readonly GasYaDbContext _dbContext;
    
    public PromotionRepository(GasYaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<PromotionAggregate> GetByIdAsync(int id)
    {
        return await _dbContext.Promotions.FindAsync(id);
    }
}