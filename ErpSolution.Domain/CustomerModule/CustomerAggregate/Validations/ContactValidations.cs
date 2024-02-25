using ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities;
using FluentValidation;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Validations;

public class ContactValidations : AbstractValidator<Contact>
{
    public ContactValidations()
    {
        RuleFor(c => c.Ddd)
            .NotEmpty().WithMessage("DDD is required")
            .GreaterThan(0).WithMessage("DDD must be greater than 0")
            .LessThan(99).WithMessage("DDD must be less than to 99");
        
        RuleFor(c => c.Phone)
            .NotEmpty().WithMessage("Phone is required")
            .GreaterThan(0).WithMessage("Phone must be greater than 0")
            .LessThanOrEqualTo(9).WithMessage("Phone must be less than or equal to 9");
    }
}