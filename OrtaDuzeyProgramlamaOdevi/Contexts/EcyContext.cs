using Microsoft.EntityFrameworkCore;
using OrtaDuzeyProgramlamaOdevi.Entities;

namespace OrtaDuzeyProgramlamaOdevi.Contexts
{
    public class EcyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ECY; Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers{ get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<LoginAdmin> LoginAdmins { get; set; }
    }
}
