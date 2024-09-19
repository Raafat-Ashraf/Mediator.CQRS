using FluentValidation;
using Mediator.CQRS.Application.Commands;

namespace Mediator.CQRS.Application.Validations;

public class AddUserCommandValidator : AbstractValidator<AddUserCommand>
{
    public AddUserCommandValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0);

        RuleFor(x => x.FirstName)
            .Length(3, 10);

        RuleFor(x => x.LastName)
            .Length(3, 10);
    }
}
