using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Models;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    
    public void Configure(EntityTypeBuilder<User> builder)
    {
        /*
        builder.HasData(
            new User { IdUser = 1, Guid = Guid.NewGuid(), Password = "password1", Mail = "user1@example.com" },
            new User { IdUser = 2, Guid = Guid.NewGuid(), Password = "password2", Mail = "user2@example.com" },
            new User { IdUser = 3, Guid = Guid.NewGuid(), Password = "password3", Mail = "user3@example.com" },
            new User { IdUser = 4, Guid = Guid.NewGuid(), Password = "password4", Mail = "user4@example.com" },
            new User { IdUser = 5, Guid = Guid.NewGuid(), Password = "password5", Mail = "user5@example.com" }
        );
        */
    }
}
