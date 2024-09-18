using DomainLayer.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Configurations
{
    public class AppRoleConfig : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
               new AppRole { Id = 1, Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = Guid.NewGuid().ToString() },
               new AppRole { Id = 2, Name = "ContentManager", NormalizedName = "CONTENTMANAGER", ConcurrencyStamp = Guid.NewGuid().ToString() },
               new AppRole { Id = 3, Name = "CustomerService", NormalizedName = "CUSTOMERSERVICE", ConcurrencyStamp = Guid.NewGuid().ToString() },
               new AppRole { Id = 4, Name = "Visitor", NormalizedName = "VISITOR", ConcurrencyStamp = Guid.NewGuid().ToString() }

               );
        }
    }
}
