using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PrensentationLayer.ViewComponents.Default
{
    public class _PizzaGalleryPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
