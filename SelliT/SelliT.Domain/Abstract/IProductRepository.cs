using System.Collections.Generic;
using SelliT.Domain.Entities;

namespace SelliT.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
