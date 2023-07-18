using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PrensentationLayer.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.title1 = "hergün pizza yiyin";
            ViewBag.title2 = "sevdğiniz pizzaları paylaşın";
            return View();
        }
    }
}
