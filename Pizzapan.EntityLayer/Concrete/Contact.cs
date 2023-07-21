using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string OpeningHours { get; set; }
        public DateTime SendMessage { get; set; }
    }
}
