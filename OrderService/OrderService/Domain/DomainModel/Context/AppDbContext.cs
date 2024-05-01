using DomainModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace DomainModel.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
    }
}
