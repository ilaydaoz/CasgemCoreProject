using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.PrensentationLayer.Models;
using System.Threading.Tasks;

namespace Pizzapan.PrensentationLayer.Controllers
{
    public class ConfirmEmailController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ConfirmEmailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.username = TempData["Username"];
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ConfirmEmailModel vm)
        {
            var user = await _userManager.FindByNameAsync(vm.UserName);
            if (user.ConfirmCode.ToString() == vm.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}