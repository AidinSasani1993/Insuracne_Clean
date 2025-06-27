using QBimeh.Application.Dtos.Users.Requests;
using QBimeh.Application.Dtos.Users.Responses;

namespace QBimeh.Application.Services.Users
{
    public interface IUserService
    {
        //Task<GetUserDto> LoginAsync(LoginDto dto);

        Task<string> CreateUserAsync(CreateUserDto dto);
    }
}
