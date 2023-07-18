using Microsoft.AspNetCore.Mvc;
using Pizzapan.BussinesLayer.Absrtact;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {
        private readonly ITestimoialService _testimonialService;
        public _TestimonialPartial(ITestimoialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetList();
            return View(values);
        }
    }
}
