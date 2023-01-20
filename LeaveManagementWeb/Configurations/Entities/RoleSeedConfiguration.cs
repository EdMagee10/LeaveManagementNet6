using LeaveManagementWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole 
                {
                    Id = "91232a6a-32e1-666a-8494-6e6b5eb3f703",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()

                },
                new IdentityRole
                {
                    Id = "91232a6b-32e1-666b-8494-6e6b5eb3f703",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()

                }               
            );
        }
    }
}
