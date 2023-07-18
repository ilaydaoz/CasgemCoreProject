using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PrensentationLayer.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
