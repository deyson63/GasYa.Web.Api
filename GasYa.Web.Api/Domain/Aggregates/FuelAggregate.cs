namespace GasYa.Web.Api.Domain.Aggregates;

public class FuelAggregate
{
    public int Id { get; private set; }
    public string Type { get; private set; }
    public string Description { get; private set; }
    public double Price { get; private set; }

    private FuelAggregate()
    {
    }

    public static FuelAggregate Create(string type, string description, double price)
    {
        var fuel = new FuelAggregate
        {
            Type = type,
            Description = description,
            Price = price
        };


        return fuel;
    }
}
