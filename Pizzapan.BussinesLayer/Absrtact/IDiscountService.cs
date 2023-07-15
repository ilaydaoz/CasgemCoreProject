
using Pizzapan.EntityLayer.Concrete;
using System;

namespace Pizzapan.BussinesLayer.Absrtact
{
    public interface IDiscountService : IGenericService<Discount>
    {
        String TRandomCreateCode();

    }
}
