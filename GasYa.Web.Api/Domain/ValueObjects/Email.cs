namespace GasYa.Web.Api.Domain.ValueObjects;

public class Email
{
    private readonly string _value;

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("El valor del correo electrónico no puede estar vacío.", nameof(value));
        }

        // Puedes agregar lógica adicional de validación de correo electrónico según tus necesidades

        _value = value;
    }

    public override string ToString()
    {
        return _value;
    }    
}