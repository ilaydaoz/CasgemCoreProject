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
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("lürfen en az 3 karakter girin");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("lürfen en fazla 30 karakter girin");
        }
    }
}
