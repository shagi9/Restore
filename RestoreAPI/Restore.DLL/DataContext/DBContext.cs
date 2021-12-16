using Microsoft.EntityFrameworkCore;
using Restore.DLL.Entities;

namespace Restore.DLL.DataContext
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options) 
        { 
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(DBContext).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
