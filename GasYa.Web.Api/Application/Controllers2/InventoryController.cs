using System.Collections.Generic;
using System.Threading.Tasks;
using GasYa.Web.Api.Domain.Aggregates;
using GasYa.Web.Api.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace GasYa.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryManagementService _inventoryService;

        public InventoryController(IInventoryManagementService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryAggregate>>> GetAllInventory()
        {
            var inventory = await _inventoryService.GetAllInventoryAsync();
            return Ok(inventory);
        }

        [HttpGet("{gasStationId}/{fuelId}")]
        public async Task<ActionResult<InventoryAggregate>> GetInventoryByIds(int gasStationId, int fuelId)
        {
            var inventory = await _inventoryService.GetInventoryByIdsAsync(gasStationId, fuelId);

            if (inventory == null)
            {
                return NotFound();
            }

            return Ok(inventory);
        }

        [HttpPost]
        public async Task<ActionResult<InventoryAggregate>> AddInventory([FromBody] InventoryCreationDto creationDto)
        {
            var inventory = await _inventoryService.AddInventoryAsync(creationDto.GasStationId, creationDto.FuelId);
            return CreatedAtAction(nameof(GetInventoryByIds), new { gasStationId = inventory.GasStationId, fuelId = inventory.FuelId }, inventory);
        }

        [HttpDelete("{gasStationId}/{fuelId}")]
        public async Task<IActionResult> DeleteInventory(int gasStationId, int fuelId)
        {
            await _inventoryService.DeleteInventoryAsync(gasStationId, fuelId);
            return NoContent();
        }
    }

    public class InventoryCreationDto
    {
        public int GasStationId { get; set; }
        public int FuelId { get; set; }
    }
}
