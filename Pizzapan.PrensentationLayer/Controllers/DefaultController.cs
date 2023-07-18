using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PrensentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
