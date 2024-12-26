using BlogSite.Entity.Entityes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Service.FluentValidator
{
    public class ArticleValidator: AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik boş geçilemez");
            RuleFor(x=>x.Content).MinimumLength(100).WithMessage("İçerik en az 100 karakter olmalıdır");
        }
    }
}
