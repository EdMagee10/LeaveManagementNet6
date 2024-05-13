using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementData.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "91232a6c-32e1-445c-8494-6e6b5eb3f703",
                    Email = "test@admin",
                    NormalizedEmail = "TEST@ADMIN",
                    NormalizedUserName = "TEST@ADMIN",
                    UserName = "test@admin",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Kehrer22$"),
                    EmailConfirmed= true,

                },
                new Employee
                {
                    Id = "91232a6d-32e1-445d-8494-6e6b5eb3f703",
                    Email = "user@admin",
                    NormalizedEmail = "USER@ADMIN",
                    NormalizedUserName = "USER@ADMIN",
                    UserName = "user@admin",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "Kehrer22$"),
                    EmailConfirmed = true

                }

            );
        }
    }
}