using System;
using System.Collections.Generic;
using SportsStore.Domain.Entities;
using System.Text;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
