using Microsoft.AspNetCore.Mvc;
using Pizzapan.BussinesLayer.Absrtact;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.PrensentationLayer.Models;
using System;
using System.IO;

namespace Pizzapan.PrensentationLayer.Controllers
{
    public class ProductImageController : Controller
    {
        private readonly IProductImageService _productImageService;

        public ProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult Index(ImageFileViewModel model)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(model.Image.FileName);
            var imageName = Guid.NewGuid() + extension; 
            var saveLocation = resource + "/wwwroot/images/" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            model.Image.CopyTo(stream);
            ProductImage productImage = new ProductImage();
            productImage.ImageURL = imageName;
            _productImageService.TInsert(productImage);

            return RedirectToAction("Index");
        }
    }
}
