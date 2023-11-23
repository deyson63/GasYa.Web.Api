namespace GasYa.Web.Api.Domain.Aggregates;

public class InventoryAggregate
{
    public int GasStationId { get; private set; }
    public int FuelId { get; private set; }

    private InventoryAggregate()
    {
        // Constructor privado para garantizar que el agregado solo se cree a través de métodos de fábrica
    }

    public static InventoryAggregate Create(int gasStationId, int fuelId)
    {
        // Lógica de validación y creación del agregado
        var inventory = new InventoryAggregate
        {
            // Asigna propiedades y realiza validaciones según sea necesario
            GasStationId = gasStationId,
            FuelId = fuelId
        };

        // Puedes agregar más lógica de negocio o validaciones aquí

        return inventory;
    }
}