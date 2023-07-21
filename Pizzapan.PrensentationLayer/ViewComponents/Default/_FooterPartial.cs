using Microsoft.AspNetCore.Mvc;
using Pizzapan.BussinesLayer.Absrtact;

namespace Pizzapan.PrensentationLayer.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        private readonly IContactService _contactservice;

        public _FooterPartial(IContactService contactservice)
        {
            _contactservice = contactservice;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactservice.TGetList();
            return View(values);
        }
    }
}
