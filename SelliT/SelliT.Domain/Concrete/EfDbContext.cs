using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelliT.Domain.Entities;
using System.Data.Entity;

namespace SelliT.Domain.Concrete
{
    // Creating the Entity Framework Context
    class EfDbContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Contractor> Contractor { get; set; }
    }
}
