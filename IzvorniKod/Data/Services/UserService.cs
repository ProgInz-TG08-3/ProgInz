using Data.Dto;
using Data.Models;
using Microsoft.AspNetCore.Identity;

public interface IUserService
{
    Task AssignRoleAsync(string userId, string role);
}

public class UserService : IUserService
{
    private readonly UserManager<User> _userManager;

    public UserService(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task AssignRoleAsync(string userId, string role)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user != null)
        {
            await _userManager.AddToRoleAsync(user, role);
        }
    }
}
