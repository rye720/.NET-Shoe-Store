using System.Collections.Generic;
using ShoeStoreDomain.Entities;

namespace ShoeStoreDomain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
