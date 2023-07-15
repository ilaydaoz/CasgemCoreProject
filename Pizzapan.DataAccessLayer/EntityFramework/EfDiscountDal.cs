using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.DataAccessLayer.Repositories;
using Pizzapan.EntityLayer.Concrete;
using System;

namespace Pizzapan.DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public string RandomCreateCode()
        {
            string[] symbols = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M" };
            int c1, c2, c3, c4;
            Random random = new Random();
            c1 = random.Next(0, symbols.Length);
            c2 = random.Next(0, symbols.Length);
            c3 = random.Next(0, symbols.Length);
            c4 = random.Next(0, symbols.Length);
            int c5 = random.Next(10, 100);
            string code = symbols[c1] + symbols[c2] + symbols[c3] + symbols[c4] + c5;
            return code;
        }
    }
}
