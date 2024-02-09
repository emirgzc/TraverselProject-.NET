using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.Announcement
{
	public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementAddDto>
	{
		public AnnouncementUpdateValidator()
		{
			RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık kısmını boş geçemezsiniz...");
			RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik kısmını boş geçemezsiniz...");
			RuleFor(x => x.Title).MaximumLength(100).WithMessage("En fazla 100 karakter giriniz...");
			RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 karakter giriniz...");
			RuleFor(x => x.Content).MaximumLength(1500).WithMessage("En fazla 1500 karakter giriniz...");
			RuleFor(x => x.Content).MinimumLength(10).WithMessage("En az 10 karakter giriniz...");
		}
	}
}
