using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelliT.Domain.Abstract;
using SelliT.Domain.Entities;

namespace SelliT.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EfDbContext context = new EfDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }

    }
   
}
