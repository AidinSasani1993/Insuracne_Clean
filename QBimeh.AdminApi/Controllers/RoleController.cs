using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QBimeh.Application.Dtos.Roles;
using QBimeh.Application.Services.Roles;

namespace QBimeh.AdminApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Create(CreateRoleDto dto)
        {
            var result = await _roleService.CreateAsync(dto);
            return Ok(result);
        }

    }
}
