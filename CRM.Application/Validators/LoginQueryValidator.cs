using CRM.Application.Users.Queries;
using FluentValidation;

namespace CRM.Application.Validators
{
    public class LoginQueryValidator : AbstractValidator<LoginQuery>
    {
        public LoginQueryValidator()
        {
            RuleFor(x => x.Login)
                .MinimumLength(3)
                .NotEmpty();
            RuleFor(x => x.Password)
                .MinimumLength(6)
                .NotEmpty();
        }
    }
}
