using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Repositories;

public interface IClientRepository
{
    Task<ClientAggregate> GetByIdAsync(int id);
    Task AddAsync(ClientAggregate client);
    Task UpdateAsync(ClientAggregate client);
}