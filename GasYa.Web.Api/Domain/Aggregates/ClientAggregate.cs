using GasYa.Web.Api.Domain.ValueObjects;

namespace GasYa.Web.Api.Domain.Aggregates;

public class ClientAggregate
{
    public int Id { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }

    // Otros miembros del agregado según las necesidades, por ejemplo, métodos de negocio

    private ClientAggregate()
    {
        // Constructor privado para garantizar que el agregado solo se cree a través de métodos de fábrica
    }

    public static ClientAggregate Create(string firstName, string lastName, string email, string password)
    {
        // Lógica de validación y creación del agregado
        var client = new ClientAggregate
        {
            // Asigna propiedades y realiza validaciones según sea necesario
            Email = new Email(email),
            Password = new Password(password)
        };

        // Puedes agregar más lógica de negocio o validaciones aquí

        return client;
    }
}