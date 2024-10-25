using Data.Models;
using Data.Services;
using DuckI.Server.Helpers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"));
});

builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection(); //ja zelim komentar ovdje

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.UseMiddleware<ExceptionMiddleware>(); // custom exception middleware

app.Run();
