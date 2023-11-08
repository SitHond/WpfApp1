using DBtest.Models;
using Microsoft.EntityFrameworkCore;

namespace DBtest
{
    public class MalContext : DbContext
    {
        public DbSet<Buket> Bukets { get; set; }
        public DbSet<Prod> Prods { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=mat;Trusted_Connection=Yes;TrustServerCertificate=True");
        }
    }
}