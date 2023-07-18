using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.PrensentationLayer.Models;
using System;
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
            Random rnd = new Random();
            int x = rnd.Next(100000, 100000);
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.SurName,
                Email = model.Email,
                UserName = model.UserName,
                ConfirmCode = x,
            };

            if (model.Passrword == model.ConfimPassrword)
            {
                var result = await _userManager.CreateAsync(appUser, model.Passrword);

                if (result.Succeeded)
                {
                    #region
                    SendMail(model, x);

                    #endregion
                    TempData["Username"] = appUser.UserName;
                    return RedirectToAction("Index", "Login");

                }

                else
                {

                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "şifeler eşleşmiyor");
            }
            return View();
        }

        private static void SendMail(RegisterViewModel model, int x)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "ilaydaozken@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.Email);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "GİRİŞYAPABİLMEK İÇİN ONAYLAMA KODUNUZ:" + x;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "DOĞRULMA KODU";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("ilaydaozken@gmail.com", "ebntuohpiykoirpp");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
        }
    }
}