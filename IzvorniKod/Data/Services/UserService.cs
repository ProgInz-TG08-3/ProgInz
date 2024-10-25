using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Services;

public interface IUserService
{
    Task<List<User>> GetUserRolesAsync();
}

public class UserService : IUserService
{
    private readonly DataContext _context;

    public UserService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetUserRolesAsync()
    {
        return await _context.Users
            .Include(u => u.Student)
            .Include(u => u.Educator)
            .Include(u => u.Administrator)
            .Include(u => u.Reviewer)
            .ToListAsync();
    }
}
