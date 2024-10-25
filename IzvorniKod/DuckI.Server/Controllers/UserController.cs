using Data.Dto;
using Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace DuckI.Server.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userRoleService;

    public UserController(IUserService userRoleService)
    {
        _userRoleService = userRoleService;
    }

    //[HttpGet("[action]")]  <-- almost the same
    [HttpGet("displayroles")]
    public async Task<IActionResult> DisplayRoles()
    {
        var users = await _userRoleService.GetUserRolesAsync();
        var userRoles = users.Select(user => new UserRolesDto
        {
            IdUser = user.IdUser,
            Guid = user.Guid,
            Role = user.Administrator != null ? "Administrator" :
                   user.Reviewer != null ? "Reviewer" :
                   user.Student != null ? "Student" :
                   user.Educator != null ? "Educator" : "None"
        }).ToList();
        return Ok(userRoles);
    }
}