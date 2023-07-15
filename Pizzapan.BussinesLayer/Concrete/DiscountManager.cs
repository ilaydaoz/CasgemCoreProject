using Pizzapan.BussinesLayer.Absrtact;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace Pizzapan.BussinesLayer.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;
        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }


        public void TDelete(Discount t)
        {
            throw new NotImplementedException();
        }

        public Discount TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Discount> TGetList()
        {
            return _discountDal.GetList();
        }

        public void TInsert(Discount t)
        {
            _discountDal.Insert(t);
        }


        public void TUpdate(Discount t)
        {
            throw new NotImplementedException();
        }


        public string TRandomCreateCode()
        {
            return _discountDal.RandomCreateCode();
        }
    }
}
