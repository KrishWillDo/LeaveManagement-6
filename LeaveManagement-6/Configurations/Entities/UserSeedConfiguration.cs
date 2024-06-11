using LeaveManagement_6.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement_6.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(

                new Employee()
                {
                    Id = "d478aa36-1256-444a-a169-474916c7f1b3",
                    Email = "krishnovatiwe@gmail.com",
                    NormalizedEmail = "KRISHNOVATIWE@GMAIL.COM",
                    UserName = "Krishnovatiwe@gmail.com",
                    NormalizedUserName = "KRISHNOVATIWE@GMAIL.COM",
                    FirstName = "Krishna",
                    LastName = "Kanth",
                    PasswordHash = hasher.HashPassword(null, "Kr1$hn@1245"),
                    TaxId = "0",
                    EmailConfirmed = true,
                },
                 new Employee()
                 {
                     Id = "d578aa36-1287-444a-b269-474916c8f1b2",
                     Email = "user@test.com",
                     NormalizedEmail = "USER@TEST.COM",
                     UserName = "user@test.com",
                     NormalizedUserName = "USER@TEST.COM",
                     FirstName = "Test",
                     LastName = "User",
                     PasswordHash = hasher.HashPassword(null, "Kr1$hn@1245"),
                     TaxId = "0",
                     EmailConfirmed = true,
                 }
               );
        }
    }
}
