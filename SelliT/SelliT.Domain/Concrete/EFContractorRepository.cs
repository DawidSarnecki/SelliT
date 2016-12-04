using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelliT.Domain.Abstract;
using SelliT.Domain.Entities;

namespace SelliT.Domain.Concrete
{
    public class EFContractorRepository : IContractorRepository
    {
        private EfDbContext context = new EfDbContext();

        public IEnumerable<Contractor> Contractor
        {
            get { return context.Contractor; }
        }

    }


}
