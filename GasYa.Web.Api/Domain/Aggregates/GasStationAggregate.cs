namespace GasYa.Web.Api.Domain.Aggregates;

public class GasStationAggregate
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    private GasStationAggregate()
    {
        // Constructor privado para garantizar que el agregado solo se cree a través de métodos de fábrica
    }

    public static GasStationAggregate Create(string name)
    {
        // Lógica de validación y creación del agregado
        var gasStation = new GasStationAggregate
        {
            // Asigna propiedades y realiza validaciones según sea necesario
            Name = name
        };

        // Puedes agregar más lógica de negocio o validaciones aquí

        return gasStation;
    }
}