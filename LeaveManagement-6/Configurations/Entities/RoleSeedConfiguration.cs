using LeaveManagement_6.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement_6.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole()
            {
                Id = "d478ab36-1256-443a-a170-474915a7f1b3",
                Name = Roles.Administrator,
                NormalizedName = Roles.Administrator.ToUpper()
            },
            new IdentityRole()
            {
                Id = "d578ab46-1234-443a-a170-474915a8g1b4",
                Name = Roles.User,
                NormalizedName = Roles.User.ToUpper()
            }
            );
        }
    }
}