using System.Collections.Generic;
using System.Threading.Tasks;
using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Services
{
    public interface IClientManagementService
    {
        Task<IEnumerable<ClientAggregate>> GetAllClientsAsync();
        Task<ClientAggregate> GetClientByIdAsync(int id);
        Task<ClientAggregate> CreateClientAsync(string firstName, string lastName, string email, string password);
        Task UpdateClientAsync(int id, string firstName, string lastName, string email, string password);
        Task DeleteClientAsync(int id);
    }
}