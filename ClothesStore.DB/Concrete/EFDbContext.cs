using ClothesStore.DB.Entities;
using System.Data.Entity;

namespace ClothesStore.DB.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}