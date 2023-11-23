namespace GasYa.Web.Api.Domain.Aggregates;

public class FuelAggregate
{
    public int Id { get; private set; }
    public string Type { get; private set; }
    public string Description { get; private set; }
    public double Price { get; private set; }

    private FuelAggregate()
    {
        // Constructor privado para garantizar que el agregado solo se cree a través de métodos de fábrica
    }

    public static FuelAggregate Create(string type, string description, double price)
    {
        // Lógica de validación y creación del agregado
        var fuel = new FuelAggregate
        {
            // Asigna propiedades y realiza validaciones según sea necesario
            Type = type,
            Description = description,
            Price = price
        };

        // Puedes agregar más lógica de negocio o validaciones aquí

        return fuel;
    }
}