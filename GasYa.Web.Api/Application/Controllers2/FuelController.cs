using System.Collections.Generic;
using System.Threading.Tasks;
using GasYa.Web.Api.Domain.Aggregates;
using GasYa.Web.Api.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace GasYa.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuelsController : ControllerBase
    {
        private readonly IFuelManagementService _fuelService;

        public FuelsController(IFuelManagementService fuelService)
        {
            _fuelService = fuelService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FuelAggregate>>> GetAllFuels()
        {
            var fuels = await _fuelService.GetAllFuelsAsync();
            return Ok(fuels);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FuelAggregate>> GetFuelById(int id)
        {
            var fuel = await _fuelService.GetFuelByIdAsync(id);

            if (fuel == null)
            {
                return NotFound();
            }

            return Ok(fuel);
        } 

        [HttpPost]
        public async Task<ActionResult<FuelAggregate>> AddFuel([FromBody] FuelCreationDto creationDto)
        {
            var fuel = await _fuelService.AddFuelAsync(creationDto.Type, creationDto.Description, creationDto.Price);
            return CreatedAtAction(nameof(GetFuelById), new { id = fuel.Id }, fuel);
        }

        // Puedes agregar acciones adicionales según sea necesario, como Update y Delete
    }

    public class FuelCreationDto
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}