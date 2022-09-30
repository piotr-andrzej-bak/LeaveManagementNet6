using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                   new Employee
                   {
                       Id = "bf7853a3-20c5-4904-a48a-7664d1b13b22",
                       Email = "admin@test.com",
                       NormalizedEmail = "ADMIN@TEST.COM",
                       UserName = "admin@test.com",
                       NormalizedUserName = "ADMIN@TEST.COM",
                       Firstname = "admin",
                       Lastname = "test",
                       PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                       EmailConfirmed = true
                   }
            );
            builder.HasData(
                   new Employee
                   {
                       Id = "bf7853a3-20c5-4904-a48a-7664d1b13b28",
                       Email = "user@test.com",
                       NormalizedEmail = "USER@TEST.COM",
                       UserName = "user@test.com",
                       NormalizedUserName = "USER@TEST.COM",
                       Firstname = "user",
                       Lastname = "test",
                       PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                       EmailConfirmed = true
                   }
            );
        }
    }
}