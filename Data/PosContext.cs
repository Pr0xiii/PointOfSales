using Microsoft.EntityFrameworkCore;
using PointOfSalesApp.Models;
using System.IO;

namespace PointOfSalesApp.Data
{
    public class PosContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            optionsBuilder.UseSqlite($"Data Source={Path.Combine(path, "pos.db")}");
        }
    }
}
