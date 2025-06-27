using Microsoft.AspNetCore.Identity;
using QBimeh.Application.Dtos.Roles;
using QBimeh.Application.Services.Roles;

namespace QBimeh.Service.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleService(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<string> CreateAsync(CreateRoleDto dto)
        {
            var role = new IdentityRole
            {
                Name = dto.Name,
            };

            await _roleManager.CreateAsync(role);

            return role.Id;
        }
    }
}
