using Microsoft.EntityFrameworkCore;
using RedisPOC.Models;

namespace RedisPOC.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> dbContextOptions) : base(dbContextOptions) 
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}
