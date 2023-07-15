using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.PrensentationLayer.Models;
using System.Threading.Tasks;

namespace Pizzapan.PrensentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Name = model.Name,
                    Surname = model.SurName,
                    Email = model.Email,
                    UserName = model.UserName
                };
                await _userManager.CreateAsync(appUser, model.Passrword);
                return RedirectToAction("Index", "Login");
            }

            else
            {
                return View();
            }
        }
    }
}
