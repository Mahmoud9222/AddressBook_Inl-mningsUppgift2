using Microsoft.EntityFrameworkCore;
using UPPDB.Models.Entities;

namespace UPPDB.Models
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<OrderRowEntity> OrdersRows { get; set; }
    }
}
