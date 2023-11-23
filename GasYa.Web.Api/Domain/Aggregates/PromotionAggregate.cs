namespace GasYa.Web.Api.Domain.Aggregates;

public class PromotionAggregate
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Description { get; private set; }

    private PromotionAggregate()
    {
        // Constructor privado para garantizar que el agregado solo se cree a través de métodos de fábrica
    }

    public static PromotionAggregate Create(string title, string description, DateTime startDate, DateTime endDate)
    {
        // Lógica de validación y creación del agregado
        var promotion = new PromotionAggregate
        {
            // Asigna propiedades y realiza validaciones según sea necesario
            Title = title,
            Description = description
        };

        // Puedes agregar más lógica de negocio o validaciones aquí

        return promotion;
    }
}