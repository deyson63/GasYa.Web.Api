using GasYa.Web.Api.Domain.Aggregates;
using GasYa.Web.Api.Domain.Repositories;
using GasYa.Web.Api.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GasYa.Web.Api.Infrastructure.Data.Repository;

public class ClientRepository : IClientRepository
{
    private readonly GasYaDbContext _dbContext;
    
    public ClientRepository(GasYaDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<ClientAggregate> GetByIdAsync(int id)
    {
        return await _dbContext.Clients.FindAsync(id);
    }

    public async Task AddAsync(ClientAggregate client)
    {
        _dbContext.Clients.Add(client);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(ClientAggregate client)
    {
        _dbContext.Entry(client).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }
}