using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
	{
		public AppUserRegisterValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Ad kısmını boş geçemezsiniz...");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad kısmını boş geçemezsiniz...");
			RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail kısmını boş geçemezsiniz...");
			RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı kısmını boş geçemezsiniz...");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre kısmını boş geçemezsiniz...");
			RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar kısmını boş geçemezsiniz...");

			RuleFor(x => x.Username).MinimumLength(5).WithMessage("Kullanıcı adı kısmı en az 5 karakter olmalıdır...");
			RuleFor(x => x.Username).MaximumLength(30).WithMessage("Kullanıcı adı kısmı en fazla 30 karakter olmalıdır...");

			RuleFor(x => x.Password).Equal(y=>y.ConfirmPassword).WithMessage("Şifreler birbiri ile uyuşmuyor...");
		}
	}
}
