using System.Collections.Generic;
using System.Threading.Tasks;
using GasYa.Web.Api.Domain.Aggregates;
using GasYa.Web.Api.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace GasYa.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromotionsController : ControllerBase
    {
        private readonly IPromotionManagementService _promotionService;

        public PromotionsController(IPromotionManagementService promotionService)
        {
            _promotionService = promotionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PromotionAggregate>>> GetAllPromotions()
        {
            var promotions = await _promotionService.GetAllPromotionsAsync();
            return Ok(promotions);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PromotionAggregate>> GetPromotionById(int id)
        {
            var promotion = await _promotionService.GetPromotionByIdAsync(id);

            if (promotion == null)
            {
                return NotFound();
            }

            return Ok(promotion);
        }

        [HttpPost]
        public async Task<ActionResult<PromotionAggregate>> AddPromotion([FromBody] PromotionCreationDto creationDto)
        {
            var promotion = await _promotionService.AddPromotionAsync(creationDto.Title, creationDto.Description, creationDto.StartDate, creationDto.EndDate);
            return CreatedAtAction(nameof(GetPromotionById), new { id = promotion.Id }, promotion);
        }

        // Puedes agregar acciones adicionales según sea necesario, como Update y Delete
    }

    public class PromotionCreationDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        // Otros campos según sea necesario
    }
}