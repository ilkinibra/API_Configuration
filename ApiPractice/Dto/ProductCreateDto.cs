using ApiPractice.Extensions;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPractice.Dto
{
    public class ProductCreateDto
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }

        public int CategoryId { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
    public class ProductCreateDtoValidator:AbstractValidator<ProductCreateDto>
    {
        public ProductCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50).WithMessage(ErrorMessage.ProductCreateDtoNameMaxLength);
        }
    }
}
