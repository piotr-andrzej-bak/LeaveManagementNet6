using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "bf7853a3-20c5-4904-a48a-7664d1b13b23",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "bf7853a3-20c5-4904-a48a-7664d1b13b24",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
                ); ;
        }
    }
}


// bf7853a3-20c5-4904-a48a-7664d1b13b22