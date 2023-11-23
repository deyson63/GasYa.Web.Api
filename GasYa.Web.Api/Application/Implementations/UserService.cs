using GasYa.Web.Api.Application.Commands;
using GasYa.Web.Api.Application.Contracts;
using GasYa.Web.Api.Application.Dtos;
using GasYa.Web.Api.Application.Queries;

namespace GasYa.Web.Api.Application.Implementations;

public class UserService : IUserService
{
    public async Task<UserDto> GetAsync(GetUserQuery query)
    {
        return new UserDto
        {
            Id = 1,
            Name = "Ejemplo",
            Email = "ejemplo@example.com"
        };
    }

    public async Task RegisteredUserAsync(RegisterUserCommand command)
    {
        
    }
}
