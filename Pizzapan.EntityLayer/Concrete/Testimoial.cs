using System.ComponentModel.DataAnnotations;

namespace Pizzapan.EntityLayer.Concrete
{
    public class Testimoial
    {
        public int TestimoialID { get; set; }
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerTitle { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
