using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Repositories;

public interface IPromotionRepository
{
    Task<PromotionAggregate> GetByIdAsync(int id);
}