using GasYa.Web.Api.Domain.ValueObjects;

namespace GasYa.Web.Api.Domain.Aggregates;

public class ClientAggregate
{
    public int Id { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }


    private ClientAggregate()
    {
    }

    public static ClientAggregate Create(string firstName, string lastName, string email, string password)
    {
        var client = new ClientAggregate
        {
            Email = new Email(email),
            Password = new Password(password)
        };


        return client;
    }
}
