using Pizzapan.BussinesLayer.Absrtact;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BussinesLayer.Concrete
{
    public class TestimoialManager : ITestimoialService
    {
        private readonly ITestimoialDal _testimoialDal;
        public TestimoialManager(ITestimoialDal testimoialDal)
        {
            _testimoialDal = testimoialDal;
        }

        public void TDelete(Testimoial t)
        {
            _testimoialDal.Delete(t);
        }

        public Testimoial TGetByID(int id)
        {
            return _testimoialDal.GetByID(id);
        }

        public List<Testimoial> TGetList()
        {
            return _testimoialDal.GetList();
        }

        public void TInsert(Testimoial t)
        {
            _testimoialDal.Insert(t);
        }

        public void TUpdate(Testimoial t)
        {
            _testimoialDal.Update(t);
        }
    }
}