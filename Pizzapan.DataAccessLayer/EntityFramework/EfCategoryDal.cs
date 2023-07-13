using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.DataAccessLayer.Repositories;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}
