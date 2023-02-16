using FluentValidation;
using WebApp.Dto;

namespace WebApp.Validations
{
    public class PackageValidator : AbstractValidator<PackageDto>
    {
        public PackageValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.PackageIdentifier).NotEmpty();
            RuleFor(x => x.Status).NotEmpty();
            RuleFor(x => x.RecipientId).GreaterThan(0);
        }
    }
}
