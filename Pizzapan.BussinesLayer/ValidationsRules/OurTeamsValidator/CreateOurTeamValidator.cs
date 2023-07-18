using FluentValidation;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BussinesLayer.ValidationsRules.OurTeamsValidator
{
    public class CreateOurTeamValidator : AbstractValidator <OurTeam>
    {
        public CreateOurTeamValidator ()
        {
            RuleFor (x => x.Name).NotEmpty ().WithMessage("isim alanı boş gelemez");
            RuleFor (x => x.Surname).NotEmpty ().WithMessage("Soyisim alanı boş gelemez");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Giriniz");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Lütfen En Fazla 30 Karakter Giriniz");
        }
    }
}
