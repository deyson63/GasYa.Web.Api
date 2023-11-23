namespace GasYa.Web.Api.Domain.Aggregates;

public class GasStationAggregate
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    private GasStationAggregate()
    {
    }

    public static GasStationAggregate Create(string name)
    {
        var gasStation = new GasStationAggregate
        {
            Name = name
        };


        return gasStation;
    }
}
