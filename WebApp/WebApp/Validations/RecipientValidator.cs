using FluentValidation;
using WebApp.Dto;

namespace WebApp.Validations
{
    public class RecipientValidator : AbstractValidator<RecipientDto>
    {
        public RecipientValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();
        }
    }
}
