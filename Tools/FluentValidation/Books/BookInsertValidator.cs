using FluentValidation;
using Library_Project.Objects.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Project.Tools.FluentValidation.Books
{
    public class BookInsertValidator : AbstractValidator<InsertBook>
    {
        public BookInsertValidator()
        {
            RuleFor(b => b.BookName).
                NotEmpty().MaximumLength(200).WithMessage("Kitap adını boş bırakamazsınız.");

            RuleFor(x => x.PublisherName).
                NotEmpty().MaximumLength(200).WithMessage("Yayınevi adını boş bırakamazsınız.");


        }
    }
}
