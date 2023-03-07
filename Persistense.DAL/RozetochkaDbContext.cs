using Microsoft.EntityFrameworkCore;
using Persistense.DAL.Entities;



namespace Persistense.DAL
{
    public class RozetochkaDbContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }

        public RozetochkaDbContext()
        {
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog= " +
                 "" +
                 "DatabaseDb;");
            
        }

    }
}
