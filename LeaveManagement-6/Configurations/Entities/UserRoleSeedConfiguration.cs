using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement_6.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>()
            {
                RoleId = "d478ab36-1256-443a-a170-474915a7f1b3",
                UserId = "d478aa36-1256-444a-a169-474916c7f1b3"
            },
            new IdentityUserRole<string>()
            {
                RoleId = "d578ab46-1234-443a-a170-474915a8g1b4",
                UserId = "d578aa36-1287-444a-b269-474916c8f1b2"
            }
            );
        }
    }
}
