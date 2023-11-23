namespace GasYa.Web.Api.Domain.Aggregates;

public class InventoryAggregate
{
    public int GasStationId { get; private set; }
    public int FuelId { get; private set; }

    private InventoryAggregate()
    {
    }

    public static InventoryAggregate Create(int gasStationId, int fuelId)
    {
        var inventory = new InventoryAggregate
        {
            GasStationId = gasStationId,
            FuelId = fuelId
        };


        return inventory;
    }
}
