using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.DataAccessLayer.Concrete;
using Pizzapan.DataAccessLayer.Repositories;
using Pizzapan.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Pizzapan.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public List<Contact> GetContactBySubjectWithTesekkur()
        {
            using var context = new Context();
            var values = context.Contacts.Where(x => x.Subject == "Teşekkür").ToList();
            return values;
        }
    }
}
