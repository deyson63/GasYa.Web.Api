using System.Collections.Generic;
using System.Threading.Tasks;
using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Services
{
    public interface IFuelManagementService
    {
        Task<IEnumerable<FuelAggregate>> GetAllFuelsAsync();
        Task<FuelAggregate> GetFuelByIdAsync(int id);
        Task<IEnumerable<FuelAggregate>> GetFuelsByTypeAsync(string fuelType);
        Task<FuelAggregate> AddFuelAsync(string type, string description, double price);
    }
}