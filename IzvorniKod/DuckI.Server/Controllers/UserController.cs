using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

    [Authorize(Roles = "Administrator")]
    [HttpGet("displayroles")]
    public async Task<IActionResult> DisplayRoles()
    {
        return Ok("Uspjeh");
    }

    [Authorize] 
    [HttpPost("selfassignrole")]
    public async Task<IActionResult> SelfAssignRole([FromBody] string role)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Get the current user's ID
        if (userId == null)
        {
            return Unauthorized();
        }

        await _userRoleService.AssignRoleAsync(userId, role);
        return Ok("Role assigned successfully");
    }
}
