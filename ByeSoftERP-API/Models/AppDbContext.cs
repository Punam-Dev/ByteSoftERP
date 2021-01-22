using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByeSoftERP_API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<UOMs> UOMs { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
