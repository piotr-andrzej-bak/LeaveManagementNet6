using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                   new IdentityUserRole<string>
                   {
                       RoleId = "bf7853a3-20c5-4904-a48a-7664d1b13b23",
                       UserId = "bf7853a3-20c5-4904-a48a-7664d1b13b22"
                   }
            );
        }
    }
}