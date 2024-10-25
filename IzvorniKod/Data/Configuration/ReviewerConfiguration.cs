using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Models;

public class ReviewerConfiguration : IEntityTypeConfiguration<Reviewer>
{
    public void Configure(EntityTypeBuilder<Reviewer> builder)
    {
        builder.HasData(
            new Reviewer { IdReviewer = 1, Guid = Guid.NewGuid(), IdUser = 4 }
        );
    }
}
