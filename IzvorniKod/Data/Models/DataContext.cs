using Microsoft.EntityFrameworkCore;

namespace Data.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) { }

    public DbSet<User>? Users { get; set; }
    public DbSet<Student>? Students { get; set; }
    public DbSet<Educator>? Educators { get; set; }
    public DbSet<Administrator>? Administrators { get; set; }
    public DbSet<Reviewer>? Reviewers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new EducatorConfiguration());
        modelBuilder.ApplyConfiguration(new AdministratorConfiguration());
        modelBuilder.ApplyConfiguration(new ReviewerConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}
