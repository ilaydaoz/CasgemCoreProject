using System.ComponentModel.DataAnnotations;

namespace Pizzapan.PrensentationLayer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage="ad boş geçilemez")]
        public string Name { get; set; }
        public string SurName { get; set; }
        [Required(ErrorMessage = "mail boş geçilemez")]
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Passrword { get; set; }
        [Required(ErrorMessage = "şireler uyuşmuyo")]
        public string ConfimPassrword { get; set; }
    }
}
