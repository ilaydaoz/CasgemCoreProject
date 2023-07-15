using Microsoft.AspNetCore.Mvc;
using Pizzapan.BussinesLayer.Absrtact;
using Pizzapan.EntityLayer.Concrete;
using System;

namespace Pizzapan.PrensentationLayer.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CreateCode()
        {

            string discountCode = _discountService.TRandomCreateCode();
            ViewBag.DiscountCode = discountCode;
            return View();
        }

        [HttpPost]
        public IActionResult CreateCode(Discount discount)
        {
            discount.CreateDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            discount.EndingDate = Convert.ToDateTime(DateTime.Now.AddDays(3));
            _discountService.TInsert(discount);
            return RedirectToAction("Index");
        }

        public IActionResult DiscountCodeList()
        {
            var valus = _discountService.TGetList();
            return View(valus);

        }
    }
}

