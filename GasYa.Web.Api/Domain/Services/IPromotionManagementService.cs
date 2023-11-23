using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Services
{
    public interface IPromotionManagementService
    {
        Task<IEnumerable<PromotionAggregate>> GetAllPromotionsAsync();
        Task<PromotionAggregate> GetPromotionByIdAsync(int id);
        Task<IEnumerable<PromotionAggregate>> GetActivePromotionsAsync(DateTime currentDate);
        Task<PromotionAggregate> AddPromotionAsync(string title, string description, DateTime startDate, DateTime endDate);
        Task UpdatePromotionAsync(int id, string title, string description, DateTime startDate, DateTime endDate);
        Task DeletePromotionAsync(int id);
    }
}