using Microsoft.AspNetCore.Http;

namespace Pizzapan.PrensentationLayer.Models
{
    public class ImageFileViewModel
    {
        public string ImageURl { get; set; }
        public IFormFile Image { get; set; }
    }
}
