using Microsoft.AspNetCore.Identity;
using QBimeh.Application.Dtos.Users.Requests;
using QBimeh.Application.Services.Users;
using QBimeh.Domain.Entities.Users;

namespace QBimeh.Service.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<string> CreateUserAsync(CreateUserDto dto)
        {
            var user = new User
            {
                Age = dto.Age,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                UserName = dto.UserName,
                Email = dto.Email,
            };

            await _userManager.CreateAsync(user, dto.Password);
            //await _userManager.AddToRoleAsync(user, dto.RoleName);
            return user.Id;

        }
    }
}
