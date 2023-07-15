using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.DataAccessLayer.Abstract
{
    public interface IDiscountDal  : IGenericDal<Discount>
    {
        string RandomCreateCode();
    }
}

