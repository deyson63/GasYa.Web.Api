using System.Collections.Generic;
using System.Threading.Tasks;
using GasYa.Web.Api.Domain.Aggregates;
using GasYa.Web.Api.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace GasYa.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientManagementService _clientService;

        public ClientsController(IClientManagementService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientAggregate>>> GetAllClients()
        {
            var clients = await _clientService.GetAllClientsAsync();
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientAggregate>> GetClientById(int id)
        {
            var client = await _clientService.GetClientByIdAsync(id);

            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        [HttpPost]
        public async Task<ActionResult<ClientAggregate>> CreateClient([FromBody] ClientCreationDto creationDto)
        {
            var client = await _clientService.CreateClientAsync(creationDto.FirstName, creationDto.LastName, creationDto.Email, creationDto.Password);
            return CreatedAtAction(nameof(GetClientById), new { id = client.Id }, client);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, [FromBody] ClientUpdateDto updateDto)
        {
            await _clientService.UpdateClientAsync(id, updateDto.FirstName, updateDto.LastName, updateDto.Email, updateDto.Password);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            await _clientService.DeleteClientAsync(id);
            return NoContent();
        }
    }

    public class ClientCreationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class ClientUpdateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
