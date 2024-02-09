using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz...");
            RuleFor(x => x.DescriptionTwo).NotEmpty().WithMessage("Başlık kısmını boş geçemezsiniz...");
            RuleFor(x => x.ImageOne).NotEmpty().WithMessage("Resim kısmını boş geçemezsiniz...");
            RuleFor(x => x.ImageTwo).NotEmpty().WithMessage("Resim kısmını boş geçemezsiniz...");
            RuleFor(x => x.TitleOne).NotEmpty().WithMessage("Başlık kısmını boş geçemezsiniz...");
            RuleFor(x => x.TitleTWo).NotEmpty().WithMessage("Başlık kısmını boş geçemezsiniz...");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("En fazla 1500 karakter giriniz...");
            RuleFor(x => x.Description).MinimumLength(25).WithMessage("En az 25 karakter giriniz...");
        }
    }
}
