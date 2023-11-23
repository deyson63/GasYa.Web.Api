using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Services;

public interface IUserRegistrationService
{
    Task<ClientAggregate> RegisterUserAsync(string firstName, string lastName, string email, string password);
    
    
    
}