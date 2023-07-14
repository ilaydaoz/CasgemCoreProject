using Pizzapan.EntityLayer.Concrete;
using System.Collections.Generic;

namespace Pizzapan.BussinesLayer.Absrtact
{
    public interface IProductService : IGenericService<Product>
    {
        public List<Product> TGetProductsWithCategory();
    }
}
