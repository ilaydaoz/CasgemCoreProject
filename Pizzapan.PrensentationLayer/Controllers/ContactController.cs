using Microsoft.AspNetCore.Mvc;
using Pizzapan.BussinesLayer.Absrtact;
using Pizzapan.EntityLayer.Concrete;
using System;

namespace Pizzapan.PrensentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            _contactService.TInsert(contact);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return View(value);
        }
        ////public IActionResult UpdateContact(Contact contact)
        //{
        //    _contactService.TUpdate(contact);
        //    return RedirectToAction("Index");
        //}
        public IActionResult GetMessageByTesekur()
        {
            var value = _contactService.TGetContactBySubjectWithTesekkur();
            return View(value);
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            contact.SendMessage = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _contactService.TInsert(contact);

            return RedirectToAction("Index", "Default");
        }
    }
}
