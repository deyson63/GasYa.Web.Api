using System.Collections.Generic;
using System.Threading.Tasks;
using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Services
{
    public interface IInventoryManagementService
    {
        Task<IEnumerable<InventoryAggregate>> GetAllInventoryAsync();
        Task<InventoryAggregate> GetInventoryByIdsAsync(int gasStationId, int fuelId);
        Task<InventoryAggregate> AddInventoryAsync(int gasStationId, int fuelId);
        Task DeleteInventoryAsync(int gasStationId, int fuelId);
        Task<int> GetFuelQuantityInStockAsync(int gasStationId, int fuelId);
    }
}