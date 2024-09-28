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
            optionsBuilder.UseSqlServer("Server=DESKTOP-LGLV727\\SQLEXPRESS;Database=PlastikDBLogger;Trusted_Connection=True;Integrated Security=True;Encrypt=False;");
        }
    }
}
