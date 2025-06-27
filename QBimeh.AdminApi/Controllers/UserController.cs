using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QBimeh.Application.Dtos.Users.Requests;
using QBimeh.Application.Services.Users;

namespace QBimeh.AdminApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateUserDto dto)
        {
            var result = await _userService.CreateUserAsync(dto);
            return Ok(result);
        }


    }
}
