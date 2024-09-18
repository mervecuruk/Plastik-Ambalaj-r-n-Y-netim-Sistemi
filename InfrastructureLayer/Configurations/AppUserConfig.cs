using DomainLayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Configurations
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            AppUser user = new AppUser
            {
                Id = 1,
                FirstName = "Super",
                LastName = "Admin",
                Email = "super@admin.com",
                NormalizedEmail = "SUPER@ADMIN.COM",
                EmailConfirmed = false,
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString()
            };

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "admin");

            builder.HasData(user);
        }
    }
}
