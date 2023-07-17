using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PrensentationLayer.Models
{
    public class CoustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Parola çok kısa en az {length} karakter girişi yapınız"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "lütfen en az 1 tane küçük harf giriniz"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "lütfen en az 1 tane büyük harf giriniz"

            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresDigit",
                Description = "lütfen en az 1 tane sayı giriniz"

            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "lütfen en az 1 tane Sembol giriniz"

            };
        }
    }
}
