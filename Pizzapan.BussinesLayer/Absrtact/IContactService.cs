using Pizzapan.EntityLayer.Concrete;
using System.Collections.Generic;

namespace Pizzapan.BussinesLayer.Absrtact
{
    public interface IContactService : IGenericService<Contact>
    {
        List<Contact> TGetContactBySubjectWithTesekkur();
    }
}
