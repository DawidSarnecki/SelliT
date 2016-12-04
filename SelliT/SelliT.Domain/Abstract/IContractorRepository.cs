using System.Collections.Generic;
using SelliT.Domain.Entities;

namespace SelliT.Domain.Abstract
{
    public interface IContractorRepository
    {
        IEnumerable<Contractor> Contractor { get; }
    }
}
