namespace GasYa.Web.Api.Domain.Aggregates;

public class PromotionAggregate
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }

    private PromotionAggregate()
    {
    }

    public static PromotionAggregate Create(string title, string description, DateTime startDate, DateTime endDate)
    {
        var promotion = new PromotionAggregate
        {
            Title = title,
            Description = description
        };


        return promotion;
    }
}
