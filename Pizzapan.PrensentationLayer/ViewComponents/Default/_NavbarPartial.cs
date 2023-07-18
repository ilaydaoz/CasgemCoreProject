using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PrensentationLayer.ViewComponents.Default
{
    public class _NavbarPartial  :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
