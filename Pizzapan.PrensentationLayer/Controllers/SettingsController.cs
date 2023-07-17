using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.PrensentationLayer.Models;
using System.Threading.Tasks;

namespace Pizzapan.PrensentationLayer.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManeger;

        public SettingsController(UserManager<AppUser> userManeger)
        {
            _userManeger = userManeger;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = await _userManeger.FindByNameAsync
                (User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = value.Name;
            model.SurName = value.Surname;
            model.Email = value.Email;
            model.City = value.City;
            model.UserName = value.UserName;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel model)
        {
            var user = await _userManeger.FindByNameAsync(User.Identity.Name);
            user.Name = model.Name;
            user.Surname = model.SurName;
            user.Email = model.Email;
            user.City = model.City;
            user.PasswordHash = _userManeger.PasswordHasher.HashPassword(user, model.Password);
            var result = await _userManeger.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }
        }
    }
}