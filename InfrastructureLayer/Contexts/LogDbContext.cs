using DomainLayer.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Contexts
{
    public class LogDbContext : DbContext
    {
        public LogDbContext()
        {
        }
        public LogDbContext(DbContextOptions<LogDbContext> options) : base(options)
        {
        }
        public DbSet<Log> logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=LAPTOP-0MKLK4U5\\SQLEXPRESS;Initial Catalog=BitirmeLogDbContext;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

            //optionsBuilder.UseSqlServer("Server=tcp:grup3.database.windows.net,1433;Initial Catalog=PPMSLogDatabase;Persist Security Info=False;User ID=grup3;Password=123Kd.01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;", options => options.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null));
        }
    }
}
