using System.Collections.Generic;
using System.Threading.Tasks;
using GasYa.Web.Api.Domain.Aggregates;
using GasYa.Web.Api.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace GasYa.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GasStationsController : ControllerBase
    {
        private readonly IGasStationManagementService _gasStationService;

        public GasStationsController(IGasStationManagementService gasStationService)
        {
            _gasStationService = gasStationService;
        }
        

        [HttpGet("{id}")]
        public async Task<ActionResult<GasStationAggregate>> GetGasStationById(int id)
        {
            var gasStation = await _gasStationService.GetGasStationByIdAsync(id);

            if (gasStation == null)
            {
                return NotFound();
            }

            return Ok(gasStation);
        }

        [HttpGet("name/{name}")]
        public async Task<ActionResult<IEnumerable<GasStationAggregate>>> GetGasStationsByName(string name)
        {
            var gasStations = await _gasStationService.GetGasStationsByNameAsync(name);

            if (gasStations == null || !gasStations.Any())
            {
                return NotFound();
            }

            return Ok(gasStations);
        }

        [HttpPost]
        public async Task<ActionResult<GasStationAggregate>> AddGasStation([FromBody] GasStationCreationDto creationDto)
        {
            var gasStation = await _gasStationService.AddGasStationAsync (creationDto.Name);
            return CreatedAtAction(nameof(GetGasStationById), new { id = gasStation.Id }, gasStation);
        }

        // Puedes agregar acciones adicionales según sea necesario, como Update y Delete
    }

    public class GasStationCreationDto
    {
        public string Name { get; set; }
     
        
    }
}
