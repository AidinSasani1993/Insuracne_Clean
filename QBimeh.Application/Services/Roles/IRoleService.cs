using QBimeh.Application.Dtos.Roles;

namespace QBimeh.Application.Services.Roles
{
    public interface IRoleService
    {
        Task<string> CreateAsync(CreateRoleDto dto);
    }
}
