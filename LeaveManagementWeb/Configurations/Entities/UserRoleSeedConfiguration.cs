using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "91232a6a-32e1-666a-8494-6e6b5eb3f703",
                    UserId = "91232a6c-32e1-445c-8494-6e6b5eb3f703"

                },
                new IdentityUserRole<string>
                {
                    RoleId = "91232a6b-32e1-666b-8494-6e6b5eb3f703",
                    UserId = "91232a6d-32e1-445d-8494-6e6b5eb3f703"

                }

            );
        }
    }
}