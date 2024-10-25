using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Models;

public class EducatorConfiguration : IEntityTypeConfiguration<Educator>
{
    public void Configure(EntityTypeBuilder<Educator> builder)
    {
        builder.HasData(
            new Educator { IdEducator = 1, IdUser = 2 }
        );
    }
}
