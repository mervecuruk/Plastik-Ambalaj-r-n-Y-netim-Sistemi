using DomainLayer.Entities.Concrete;
using DomainLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Contexts
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OfferCart> OfferCarts { get; set; }
        public DbSet<OfferCartMessage> OfferCartMessages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Sss> Sss { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> { UserId = 1, RoleId = 1 });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=LAPTOP-0MKLK4U5\\SQLEXPRESS;Initial Catalog=BitirmeAppDbContext;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

            //optionsBuilder.UseSqlServer("Server=tcp:grup3.database.windows.net,1433;Initial Catalog=PPMSDatabase;Persist Security Info=False;User ID=grup3;Password=123Kd.01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;", options => options.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null));
        }


    }
}
