using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DuckI.Server.Helpers;

public static class MigrationsHelper
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope serviceScope = app.ApplicationServices.CreateScope();
        using DataContext context = serviceScope
            .ServiceProvider
            .GetRequiredService<DataContext>();
        context.Database.Migrate();
    }
}
