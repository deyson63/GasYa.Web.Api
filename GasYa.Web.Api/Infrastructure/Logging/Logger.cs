namespace GasYa.Web.Api.Infrastructure.Logging;

public class Logger : ILogger
{
    public void LogInformation(string message)
    {
        Console.WriteLine($"[INFO] {DateTime.Now: MM/dd/yyyy HH:mm:ss} {message}");
    }

    public void LogError(string message, Exception exception)
    {
        Console.WriteLine($"[ERROR] {DateTime.Now: MM/dd/yyyy HH:mm:ss} {{message}}\nException: {{exception}}");
    }
}