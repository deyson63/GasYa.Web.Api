using GasYa.Web.Api.Application.Commands;
using GasYa.Web.Api.Application.Dtos;
using GasYa.Web.Api.Application.Queries;

namespace GasYa.Web.Api.Application.Contracts;

public interface IUserService
{
    Task<UserDto> GetAsync(GetUserQuery query);
    Task RegisteredUserAsync(RegisterUserCommand command);
}