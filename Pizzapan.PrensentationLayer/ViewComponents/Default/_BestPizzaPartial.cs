using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PrensentationLayer.ViewComponents.Default
{
    public class _BestPizzaPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
