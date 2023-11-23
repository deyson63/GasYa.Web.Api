namespace GasYa.Web.Api.Domain.ValueObjects;

public class Password
{
    private readonly string _value;

    public Password(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("El valor de la contraseña no puede estar vacío.", nameof(value));
        }


        _value = value;
    }

    public override string ToString()
    {
        return _value;
    }
}
