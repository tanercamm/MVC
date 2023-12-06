using System.Reflection;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Config;

namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // YONTEM 1
            // modelBuilder.ApplyConfiguration(new ProductConfig());
            // modelBuilder.ApplyConfiguration(new CategoryConfig());

            // YONTEM 2
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

    }
}
